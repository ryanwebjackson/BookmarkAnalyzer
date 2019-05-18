create table BookmarkFolder
(
    Id int identity
        primary key,
    Title varchar(100) default NULL,
    LastModified datetime default NULL,
    DateAdded datetime default NULL
)
go

create unique index BookmarkFolder_Id_uindex
    on BookmarkFolder (Id)
go

create table Attributes
(
    Id int identity
        primary key,
    AttributeKey varchar(max) not null,
    AttributeValue varchar(max) not null
)
go

create table BookmarkFolderAttributes
(
    Id int identity
        primary key,
    BookmarkFolderId int not null,
    AttributeId int not null
)
go

create unique index BookmarkFolderAttributes_Id_uindex
    on BookmarkFolderAttributes (Id)
go

create table BookmarkLink
(
    Id int identity
        primary key,
    Title varchar(max) default NULL,
    Url varchar(max),
    FeedUrl varchar(max),
    IconUrl varchar(max),
    IconData varbinary(1),
    IconContentType varchar(50),
    LastVisit datetime,
    LastModified datetime,
    Added datetime not null,
    Description varchar(max)
)
go

create unique index BookmarkLink_Id_uindex
    on BookmarkLink (Id)
go

create table BookmarkLinkAttributes
(
    Id int identity
        primary key,
    BookmarkLinkId int not null,
    AttributeId int not null
)
go

create unique index BookmarkLinkAttributes_Id_uindex
    on BookmarkLinkAttributes (Id)
go

