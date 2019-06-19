using System.Collections.Generic;

namespace interfaces {

    //custom compararer for animal class.
    class AnimalComparer : IEqualityComparer<IAnimal> {
        public bool Equals(IAnimal animal1, IAnimal Animal2)
        {
            return animal1.Name() == Animal2.Name();
        }

    public int GetHashCode(IAnimal Animal)
    {
        //Get hash code for the Name field if it is not null.
        int hashName = Animal.Name() == null ? 0 : Animal.Name().GetHashCode();
        return hashName;
    }

    }
}