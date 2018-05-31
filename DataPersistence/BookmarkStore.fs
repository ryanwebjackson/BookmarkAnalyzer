namespace DataPersistence

    open System.Collections
    open System.Collections.Generic
    open System.Collections.ObjectModel
    open BookmarksManager // Third-party helper library
    open FSharp.Data.Sql
    open FSharp.Configuration

    module BookmarkStore =
        open System

        type Settings = AppSettings<"app.config">

        let mutable private _bookmarkItems = new List<KeyValuePair<string, IBookmarkItem>>()
        // ^Consider using Concurrent classes for the above.

        let saveBookmarkItem(bookmarkItem:IBookmarkItem, username:string) =
            _bookmarkItems.Add(new KeyValuePair<string, IBookmarkItem>(username, bookmarkItem))

        let SaveBookmarkItemsForUser(bookmarkItems:Collection<IBookmarkItem>, username:string) =
            Seq.iter (fun item -> saveBookmarkItem item)

        let GetBookmarkItemsForUser(username:string) =
            let results:IEnumerable<KeyValuePair<string, IBookmarkItem>> = Seq.filter (fun item -> item.Key = username) _bookmarkItems
            Seq.map (fun (result:KeyValuePair<string, IBookmarkItem>) -> result.Value) results
