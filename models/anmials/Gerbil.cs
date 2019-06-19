namespace interfaces {
    class Gerbil : Animal, ICrawler, IDigger, ISubterraneanMammals{
        public Gerbil (){
            _name = "Gerbil";
        }

        public void Dig(){}

        public void Crawl(){}
    }
}