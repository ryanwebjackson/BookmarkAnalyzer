using System;

namespace BookmarkDataProcessor
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //TODO: Provide path input from command line (FIRST)

            //TODO: Accept posted file via API (THIRD -- Grunt work)

            var reader = new BookmarksManager.NetscapeBookmarksReader();

            var inputStream = new System.IO.FileStream(
                path: @"/Users/ryanjackson/Google Drive/bookmarks_8_26_17.html",
                mode: System.IO.FileMode.Open
            );
            var readerResult = reader.Read(inputStream);

            //TODO: Use 'DataPersistence', with a new service account, to sync data with Azure. (SECOND)

            Console.WriteLine("Goodbye world.");
        }
    }
}
