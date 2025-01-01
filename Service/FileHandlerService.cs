using Emmetienne.CustomApiPluginTypeIdSanitizer.EventBus;
using System;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace Emmetienne.CustomApiPluginTypeIdSanitizer.Service
{
    internal class FileHandlerService
    {
        private readonly LogService logService;

        public FileHandlerService(LogService logService)
        {
            this.logService = logService;

            EventBusSingleton.Instance.initSolutionZipToSanitizeFilePath += SelectSolutionZip;
            EventBusSingleton.Instance.initSelectSanitizedSolutionPathFolder += SelectDestinationFolder;
        }

        public void ExtractSolutionZip(string archiveFilePath, string destinationPath)
        {
            if (string.IsNullOrEmpty(archiveFilePath))
                throw new ArgumentException("Zip file path cannot be null or empty", nameof(archiveFilePath));

            if (string.IsNullOrEmpty(destinationPath))
                throw new ArgumentException("Extract path cannot be null or empty", nameof(destinationPath));

            if (!File.Exists(archiveFilePath))
                throw new FileNotFoundException("The specified zip file does not exist", archiveFilePath);

            try
            {
                Directory.CreateDirectory(destinationPath);
                ZipFile.ExtractToDirectory(archiveFilePath, destinationPath);

                logService.LogInfo($"Zip file extracted to {destinationPath}");
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while extracting the zip file", ex);
            }
        }

        public string[] EnumerateFolders(string path)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentException("Path cannot be null or empty", nameof(path));

            if (!Directory.Exists(path))
                throw new DirectoryNotFoundException("The specified path does not exist");

            try
            {
                return Directory.GetDirectories(path);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while enumerating the folders", ex);
            }
        }

        public void CompressFolderToZip(string sourceFolderPath, string destinationFolder, string fileName)
        {
            if (string.IsNullOrEmpty(sourceFolderPath))
                throw new ArgumentException("Source folder path cannot be null or empty", nameof(sourceFolderPath));

            if (string.IsNullOrEmpty(destinationFolder))
                throw new ArgumentException("Destination zip file path cannot be null or empty", nameof(destinationFolder));

            if (!Directory.Exists(sourceFolderPath))
                throw new DirectoryNotFoundException("The specified source folder does not exist");

            if (!Directory.Exists(destinationFolder))
                Directory.CreateDirectory(destinationFolder);

            var destinationZipFilePath = Path.Combine(destinationFolder, fileName);

            ZipFile.CreateFromDirectory(sourceFolderPath, destinationZipFilePath);
        }


        private void AddDirectoryToZip(ZipArchive archive, string sourceDir, string entryName)
        {
            foreach (string file in Directory.GetFiles(sourceDir))
            {
                string entryPath = Path.Combine(entryName, Path.GetFileName(file));
                archive.CreateEntryFromFile(file, entryPath, CompressionLevel.Optimal);
            }

            foreach (string directory in Directory.GetDirectories(sourceDir))
            {
                string directoryName = Path.GetFileName(directory);
                string entryPath = Path.Combine(entryName, directoryName);
                AddDirectoryToZip(archive, directory, entryPath);
            }
        }

        public void DeleteFolder(string folderPath)
        {
            if (string.IsNullOrEmpty(folderPath))
                throw new ArgumentException("Folder path cannot be null or empty", nameof(folderPath));

            if (!Directory.Exists(folderPath))
                throw new DirectoryNotFoundException("The specified folder does not exist");

            try
            {
                Directory.Delete(folderPath, true);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while deleting the folder", ex);
            }
        }

        public void SelectDestinationFolder()
        {
            var folderBrowserDialog = new FolderBrowserDialog();

            var result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                EventBusSingleton.Instance.setSanitizedSolutionPath?.Invoke(folderBrowserDialog.SelectedPath);
            }
        }

        public void SelectSolutionZip()
        {
            // open a dialog to select a zip file
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Zip files (*.zip)|*.zip",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(openFileDialog.FileName))
            {
                EventBusSingleton.Instance.setSolutionZipToSanitizeFilePath?.Invoke(openFileDialog.FileName);
            }
        }
    }
}
