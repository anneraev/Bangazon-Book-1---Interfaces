namespace interfaces{
    class Ant : Animal, IDigger{
        public Ant (){
            _name = "Ant";
        }
        public void Dig(){}
    }
}