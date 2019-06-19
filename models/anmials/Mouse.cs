namespace interfaces {
    class Mouse : Animal, ICrawler, IDigger, ISubterraneanMammals{

        public Mouse (){
            _name = "Mouse";
        }
        public void Crawl(){}
        public void Dig(){}
    }
}