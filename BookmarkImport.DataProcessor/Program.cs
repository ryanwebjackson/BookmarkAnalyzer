using BookmarksManager;
using System;
using System.Collections.ObjectModel;
using DataPersistence;
using System.Linq;

namespace BookmarkDataProcessor
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var path = ParseBookmarkPathFromInputArgs(args);

            //TODO: Accept posted file via API (THIRD -- busy work)

            var reader = new BookmarksManager.NetscapeBookmarksReader();
            var inputStream = new System.IO.FileStream(
                path: path,
                mode: System.IO.FileMode.Open
            );
            BookmarksManager.BookmarkFolder readerResult = reader.Read(inputStream);
            var exampleBookmarkType = readerResult.GetBookmarksBar().AllItems.First().GetType();

            // "The type arguments for the method cannot be inferred from the usage..." CS0411
            //BookmarkStore.SaveBookmarkItemsForUser(bookmarkItems: readerResult.ToList(), username: "ryjackson");

            Console.WriteLine("Goodbye world.");
        }

        private static string ParseBookmarkPathFromInputArgs(string[] args)
        {
            return @"/Users/ryanjackson/Google Drive/bookmarks_8_26_17.html"; //DEBUG/PoC
        }
    }
}
