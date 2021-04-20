# DB04 zandbak

Dit project bevat de zandbak van DB04

## Persistentie data

Dit project maakt gebrukt van Entity Framework Core. Iedere keer als je een wijziging maakt in Db04.Core entiteiten (bijvoorbeeld `Account.cs`), vergeet dan niet een migratie te maken.

Commando voor migraties:

```bash
dotnet ef migrations add CreateAccount --startup-project=Db04.Web --project=Db04.DataAccess
```

Commando voor het updaten van je database

```bash
dotnet ef database update --startup-project=Db04.Web --project=Db04.DataAccess
```

## Links naar functioneel en technisch ontwerp

https://git.fhict.nl/timodeaap/documentatie/jweet-ik-veel.doc