using BookmarksManager;
using System;
using System.Collections.ObjectModel;
using DataPersistence;
using System.Linq;

namespace BookmarkDataProcessor
{
    public static class Main
    {
        public static int LoadNetscapeStyleBookmarkFile(string path)
        {
            Console.WriteLine("Start DataProcessor Main");

            var reader = new BookmarksManager.NetscapeBookmarksReader();
            var inputStream = new System.IO.FileStream(
                path: path,
                mode: System.IO.FileMode.Open
            );
            BookmarksManager.BookmarkFolder readerResult = reader.Read(inputStream);
            int recordsLoaded = readerResult.Count;
            BookmarkStore.SaveBookmarkItemsForUser<IBookmarkItem>(bookmarkItems: readerResult, username: "ryjackson");

            Console.WriteLine("End DataProcessor Main.");

            return recordsLoaded;
        }
    }
}
