namespace interfaces {
    class Terrapin : Animal, ISwimmer, ICrawler, IAmphibiousReptile{
        public Terrapin (){
            _name = "Terrapin";
        }
        public void Swim(){}

        public void Crawl(){}
    }
}