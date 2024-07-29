# ProductContext

Repositório para teste de implementação de um projeto do ecossistema `dotnet` na infraestrutura do `ist-dev`.

---

## Infos

### Tech Stack

#### Main Techs

- Language : `C-Sharp` (^8.0.x)
- Web Application framework : `ASP.NET` (^8.0.7)
- Database : `PostgreSQL` (^15.4)
- Object-Relational Mapping (ORM) : `EntityFramework` (^8.0.7)
- Build : `MSBuild` (^17.8.5)

#### Libraries

- Package manager : `NuGet` (^6.8.1)
- Schema validation : `FluentValidation` (^x.x.x)
- API documentation : `AspNetCore.OpenApi` (8.0.7) | `OpenAPI` (3.0.3)
- Technical documentation : `docfx` (0.0.41)

#### Development Environment

- OS : `Win` (11) | `WSL 2` (Ubuntu 22.04) | `Dev Container`
- IDE : `VS Code` (^1.83.0) | `VS` (^17.0)
- Virtualization : `Docker` (26.0.0) | `docker compose` (v2.26.1)

---

## Getting Started

After clone repo, is require install all dependencies (packages), like `npm i` you can use:

```bash
dotnet restore
```

> Some commands require Entity Framework CLI (`dotnet-ef`), you can install this "Tool" with:
>
> ```bash
> dotnet tool install --global dotnet-ef
> ```

> OBS: É necessário ter as variáveis de ambiente já configuradas (.env).

Apply all migration on Database

```bash
dotnet-ef database update
```

> To populate your database (Seed):
>
> run the file [`seed.sql`](src/Infrastructure/Database/Seed/seed.sql).

Run project:

```bash
dotnet watch run
```
