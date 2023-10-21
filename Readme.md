## Fromulatrix Bootcamp Batch 6

### Setup
- Download dan install:
    - .NET SDK
    - VS Code
- Extension:
    - C#
    - VS Code Solution Explorer
    - (optional) Live share, C# Curly Formatter, Tabnine
- Setting Autosave
- Git ignore

    `dotnet new gitignore`

    masukkan folder yang di-ignore (*.bin dan *.obj)

### Workspace C#

**Struktur**

    Solution Folder (Workspace)
        |- .sln
        |> Project1
        |   |- .csproj
        |   |- Program.cs
        |> Project2
            |> obj
            |> bin
            |- .csproj
            |- Program.cs

- obj dan bin merupakan file yang muncul setelah proses compile
- obj berisi source program yang digunakan
- bin berisi hasil compile

**Membuat Solution**

1. Buat folder solution
    
    New Folder atau `mkdir`
    
2. Akses folder solution
    
    `cd [..]`
3. Inisialisasi solution
    
    `dotnet new solution`

**Membuat Project**

1. Buat folder project
    
    New Folder atau `mkdir`

2. Akses folder project
    
    `cd [..]`
3. Inisialisasi project
    
    `dotnet new console`