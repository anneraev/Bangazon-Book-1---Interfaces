namespace interfaces {
    class BettaFish : Animal, ISwimmer, ISolitary{

        public BettaFish (){
            _name = "Betta Fish";
        }
        public void Swim(){}

        public void Fight(){}
    }
}