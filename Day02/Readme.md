### Day 2
#### Membuat Class
**Contoh**

    class Bird {                        // class
      |     |
*keyword* *name*
        public string name;             // attribute / variable / state
           |      |      |
*access modifier* |    *name*
            *variable type*

        public Bird(string name) {      // class constructor
            this.name = name;
        }

        public void Eat() {             // method
           |      |     |
*access modifier* |   *parameter/argument*
            *return type*
        }
    }

*Note:*
- Konvensi penamaan
    - PascalCase : digunakan untuk nama class dan method
    - camelCase  : digunakan untuk nama variabel
- Bagian-bagian class:
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

#### string concat, string interpolation
#### user defined data type: class (class as data type)
#### namespace
#### inheritance