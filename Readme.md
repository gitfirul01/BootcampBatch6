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
2. Workspace C#

    **Struktur**

        Solution Folder (Workspace)
         |- .sln
         |- Project1
         |   |- .csproj
         |   |- Program.cs
         |- Project2
             |- .csproj
             |- Program.cs

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
5. OOP Class Diagram

    **Struktur**

    | name          |
    | ------------- |
    | + var1: type  |
    | + var2: type  |
    | + ...         |
    | + method1()   |
    | + method2()   |
    | + ...         |
    
    **Bagian**

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










































Day08

EventHandler
    - biasa  : public delegate void EventHandler(object sender, EventArgs e)
    - generic: public delegate void EventHandler<T>(object sender, T e)

Action
    delegate yang hanya punya **input**
    - Action<T1>: public delegate void Action(T1 args)
    - Action<T1, ..., T16>: public delegate void Action(T1 args, .... T16 args16)

Func
    delegate yang hanya punya **output**
    - Func<T1>: public delegate T Func()
    - Func<T1, ..., T16>: public delegate T16 Func(T1 args, .... T15 args16)
            |        |                     |        |
          input    output               output    input





Enum = Collection of constant
    
    ex:
        - pi = 3.14
        - 404 = Not Found