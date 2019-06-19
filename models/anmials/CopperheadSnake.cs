namespace interfaces {
    class CopperheadSnake : Animal, ICrawler, ISwimmer, IAmphibiousReptile {
        public CopperheadSnake (){
            _name = "Copperhead Snake";
        }

        public void Crawl(){}

        public void Swim(){}
    }
}