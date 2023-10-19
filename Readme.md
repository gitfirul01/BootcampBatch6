## Fromulatrix Bootcamp Batch 6

### Day 1
1. Setup
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
2. Struktur Workspace C#

     Solution Folder (Workspace)
        .sln
        Project1
            .csproj
            Program.cs
        Project2
            .csproj
            Program.cs

3. Membuat Solution
    1. Buat folder solution
        
        New Folder atau `mkdir`
        
    2. Akses folder solution
        
        `cd [..]`
    3. Inisialisasi solution
        
        `dotnet new solution`
4. Membuat Project
    1. Buat folder project
        
        New Folder atau `mkdir`

    2. Akses folder project
        
        `cd [..]`
    3. Inisialisasi project
        
        `dotnet new console`
5. OOP class diagram
    | name          |
    | ------------- |
    | + var1: type  |
    | + var2: type  |
    | + ...         |
    | + method1()   |
    | + method2()   |
    | + ...         |
    > Bagian:

        1. nama
        2. attribute / variabel / state
        3. method / function / behavior
### Day 2
- membuat class
- penamaan pascal case / camel case
- bagian2 class:
    - class keyword
    - class name
    - attribute:
        - access modifier
        - var type
        - var name
    - constructor
    - method:
        - access modifier
        - return type
        - argument
- string concat, string interpolation
- class constructor
- user defined data type: class
- namespace
- inheritance

### Day 3
- Encapsulation: ngebungkus variabel / fungsi supaya hanya bisa digunakan oleh orang2 tertentu => access modifier
- Access modifier
- Memberi validasi pada access modifier
- properties: {get;set;}
