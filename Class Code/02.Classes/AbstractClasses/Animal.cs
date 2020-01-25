using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    abstract class Animal
    {
        public abstract bool Feathers { get; set; }

        public virtual string Describe()
        {
            return "This is info for animal: ";
        }

        public abstract string Features();

        public abstract bool HasFeathers();
    }

    class Dog : Animal
    {
        public override bool Feathers { get; set; }
        public override string Describe()
        {
            return base.Describe() + " This is a dog.";
        }

        public override string Features()
        {
            return "Can bark";
        }

        public override bool HasFeathers()
        {
            return false;
        }

    }


    class Bird : Animal
    {
        public override bool Feathers { get; set; }
        public override string Describe()
        {
            return base.Describe() + " This is a bird.";
        }

        public override string Features()
        {
            return "Can sing";
        }

        public override bool HasFeathers()
        {
            return true;
        }
    }


}
