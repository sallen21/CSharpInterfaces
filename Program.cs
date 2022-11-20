using System;

namespace lesson08HandsOn{

    public interface Mammal : Animal{
        string speak();
        string run();
    }

    public interface Animal{      
        string eat();
    }

    public class Dog: Mammal, Animal{
        public string speak(){
            return "Bark!";
        }
        public string run(){
            return "Dogs can run at a top speed of 45 mph!";
        }
        public string eat(){
            return "Dogs eat bones.";
        }

    }

    public class Cat: Mammal, Animal{
        public string speak(){
            return "Meow!";
        }
        public string run(){
            return "Cats can run at a top speed of 30 mph!";
        }
        public string eat(){
            return  "Cats eat mice.";
        }

    }

    public class Cow: Mammal, Animal{
        public string speak(){
            return "Moo!";
        }
        public string run(){
            return "Cows can run at a top speed of 25 mph!";
        }
        public string eat(){
            return  "Cows eat grass.";
        }

    }

    class Program{
    static void Main(string[] args){
        
        

    }
    }

    

}
