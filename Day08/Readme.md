### Day 8
#### EventHandler
- biasa  : public delegate void EventHandler(object sender, EventArgs e)
- generic: public delegate void EventHandler<T>(object sender, T e)

#### Action
delegate yang hanya punya **input**
- Action<T1>: public delegate void Action(T1 args)
- Action<T1, ..., T16>: public delegate void Action(T1 args, .... T16 args16)

#### Func
delegate yang hanya punya **output**
- Func<T1>: public delegate T Func()
- Func<T1, ..., T16>: public delegate T16 Func(T1 args, .... T15 args16)
        |        |                     |        |
      input    output               output    input

#### Enum = Collection of constant
ex:
    - pi = 3.14
    - 404 = Not Found