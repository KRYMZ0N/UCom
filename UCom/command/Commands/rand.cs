using System;
using util;

namespace commands {

    public class rand : Command 
    {
        public rand(String name = "random command", String key = "rand") : base(name, key)
        {
            this.name = name;
            this.key = key;
        }

        public override void Start() 
        {
            funcs func = new funcs();
            lists list = new lists();

            Console.WriteLine(func.Random(list.animals));
        }
    }
}