namespace interfaces {
    class Parakeet : Animal, IFlyer {

        public Parakeet (){
            _name = "Parakeet";
        }
        public void fly(){}
    }
}