using System.Collections.Generic;

namespace FileSystemExercise
{
    internal class ChangedFilesCounter
    {

        private HashSet<string> files;

        public ChangedFilesCounter(IFileSystem fileSystem)
        {
            this.files = new HashSet<string>();

            fileSystem.FileCreated += OnFileModified;
            fileSystem.FileDeleted += OnFileModified;
            fileSystem.FileWritten += OnFileModified;
        }

        public int ChangeCount => files.Count;

        public void OnFileModified(string path)
        {
            files.Add(path);
        }
    }
}
