# Tweetbook
This repository due to following a video tutorial by Nick Chapsas.


# Entity Framewrok
When things has changes that could be a DbSet has been added we need to tell Entity framework that something has happend.

This is done with the following two steps:

Powershell:
* Add-Migration "Description"
* Update-Database

dotnet:
* dotnet ef migrations add <some\-descriptive\-text>
* dotnet ef database update