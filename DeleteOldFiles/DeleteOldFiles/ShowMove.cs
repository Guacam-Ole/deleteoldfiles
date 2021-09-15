using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeleteOldFiles
{
    public partial class ShowMove : Form
    {
        private Settings _settings;

        public ShowMove()
        {
            InitializeComponent();
            LoadSettings();
            //  MoveWindow();
        }

        private void MoveWindow()
        {
            var left = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            this.Left = left;
            this.Top = 0;
        }

        private void CreatePaths()
        {
            foreach (var subdir in _settings.Rules.Select(q=>q.SubDirectoryName))
            {
                if (subdir != string.Empty) Directory.CreateDirectory(Path.Combine(_settings.Path, subdir));
            }
        }
        private void LoadSettings()
        {
            try
            {
                using (TextReader tr = new StreamReader(Path.Combine(Application.StartupPath, "settings.json")))
                {
                    _settings = JsonConvert.DeserializeObject<Settings>(tr.ReadToEnd());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Settings-File defect");
                this.Close();
            }
        }

        private IEnumerable<FileInfo> GetFilesOlderThan(int days, string subdirectory = null)
        {
            return new DirectoryInfo(Path.Combine(_settings.Path, subdirectory ?? string.Empty)).GetFiles().Where(q => q.CreationTime < DateTime.Now.AddDays(-days));
        }

        private void DeleteFiles(DeleteMoveRule deleteRule)
        {
            lblMove.Text = $"Deleting files after {deleteRule.RunAfterDays} days";
            var moveDirectories = _settings.Rules.Where(q => !q.Delete).Select(q => q.SubDirectoryName);
            foreach (var moveDirectory in moveDirectories)
            {
                DeleteFiles(deleteRule, moveDirectory);
            }
        }

        private void DeleteFiles(DeleteMoveRule deleteRule, string subDirectory)
        {
            var filesToDelete = GetFilesOlderThan(deleteRule.RunAfterDays, subDirectory);
            prgDelete.Value = 0;
            prgDelete.Maximum = filesToDelete.Count();

            foreach (var oldFile in filesToDelete)
            {
                File.Delete(oldFile.FullName);
                prgDelete.Value++;
                Application.DoEvents();
            }
        }

        private void MoveFiles(DeleteMoveRule moveRule)
        {
            lblMove.Text = $"Moving files after {moveRule.RunAfterDays} days to {moveRule.SubDirectoryName}";

            var moveDirectories = _settings.Rules.Where(q => !q.Delete && q.SubDirectoryName != moveRule.SubDirectoryName).Select(q => q.SubDirectoryName).ToList();
            moveDirectories.Add(string.Empty);

            foreach (var moveDirectory in moveDirectories)
            {


                var filesToMove = GetFilesOlderThan(moveRule.RunAfterDays, moveDirectory);
                prgMove.Value = 0;
                prgMove.Maximum = filesToMove.Count();

                foreach (var oldFile in filesToMove)
                {
                    File.Move(oldFile.FullName, Path.Combine(_settings.Path, moveRule.SubDirectoryName, oldFile.Name), true);
                    prgMove.Value++;
                    Application.DoEvents();
                }
            }
        }

        private void MoveFiles()
        {
            var moveRules = _settings.Rules.Where(q => !q.Delete).OrderBy(q => q.RunAfterDays);
            if (moveRules.Count() == 0)
            {
                lblMove.Text = "Nothing to move";
                return;
            }
            foreach (var moveRule in moveRules)
            {
                MoveFiles(moveRule);
            }
        }

        private void DeleteFiles()
        {
            var deleteRules = _settings.Rules.Where(q => q.Delete).OrderBy(q => q.RunAfterDays);
            if (deleteRules.Count() == 0)
            {
                lblMove.Text = "Nothing to move";
                return;
            }
            foreach (var deleteRule in deleteRules)
            {
                DeleteFiles(deleteRule);
            }
        }

        private void ShowMove_Load(object sender, EventArgs e)
        {
            MoveWindow();
            CreatePaths();
            MoveFiles();
            DeleteFiles();
            this.Close();
        }
    }
}
