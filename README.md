# CMCS.Web (ASP.NET Core MVC GUI-only, renamed models)

This starter avoids CS0101 by using unique model names:
- `ClaimSummary` (replaces ClaimViewModel)
- `ClaimEntry` (replaces ClaimEntryVm)

## Run
1. Open folder in Visual Studio 2022+ or open `CMCS.Web_Renamed.sln`.
2. Build & Run (F5). Default route: `/Home/Index`.

## Pages
- Dashboard (Index)
- Create Claim (Create)
- Approver Queue (Queue)