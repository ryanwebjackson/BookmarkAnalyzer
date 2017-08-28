namespace DataPersistence

    open System.Collections.ObjectModel
    open BookmarksManager

    type BookmarkStore() =

        member this.SaveDataForUser(bookmarkItems:Collection<IBookmarkItem>, username:string) =
            bookmarkItems |> printf "DEBUG; bookmarkItems: %A"
            username |> printf "DEBUG; username: %s"
