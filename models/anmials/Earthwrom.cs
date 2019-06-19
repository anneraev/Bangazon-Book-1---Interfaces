namespace interfaces{
    class Earthworm : Animal, IDigger{
        public Earthworm (){
            _name = "Earthworm";
        }
        public void Dig(){}
    }
}