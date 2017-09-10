namespace DataPersistence

    open System.Collections.ObjectModel
    open BookmarksManager
    //open FSharp.Data.Sql //SQL type provider package removed -- Trying EF instead.
    open FSharp.Configuration
    open System.Data
    open System.Data.Entity

    type AzureBookmarkStoreDataContext(connString:string) =
        inherit DbContext(connString)

    type BookmarkStore() =

        //type Settings = AppSettings<"app.config"> // Why can't type providers be used in constructor?
        member this.dbCtx = new AzureBookmarkStoreDataContext("placeholderForConnectionString")

        member this.SaveDataForUser(bookmarkItems:Collection<IBookmarkItem>, username:string) =
            bookmarkItems |> printf "DEBUG; bookmarkItems: %A"
            username |> printf "DEBUG; username: %s"
            printf "TODO: Save the items to Azure using DbContext"
