
string restart = "a";

while (restart == "a")
{
    Console.WriteLine();
    Console.WriteLine("Hello traveler. What is your name?");

    string name = Console.ReadLine();

    Console.WriteLine($"Hello {name}.");
    Console.ReadLine();
    Console.WriteLine("Press enter to continue reading.");
    Console.WriteLine("Write A, B or C(depending on the amount of choices) to make you choice.");
    Console.ReadLine();
    if (name == "King fishy the third of the fish kingdom fishlandia")
    {
        Console.WriteLine("You should not be here your majesty. There could be assasins lurking around here.");
        Console.ReadLine();
        Console.WriteLine("A masked man steps out from behind a rock and shoots you with his gun.");
        Console.ReadLine();
        Console.WriteLine("Fishy Ending (0/12)");
    }
    else if (name == "Cringe Lord")
    {
        Console.WriteLine("The system can't handle that much cringe and automaticly deletes you.");
        Console.ReadLine();
        Console.WriteLine("Why would you choose that name?");
    }
    else
    {
        //Start of the story
        Console.WriteLine("You are in an unkown area...although you don't know that since you are sleeping. Do you wake up? A:Yes B:No");
        string answer = Console.ReadLine().ToLower();
        if (answer == "b")
        {
            //You choose to sleep
            Console.WriteLine("Since you are still sleeping you are easy prey for predators and get eaten by something...Probably a duck...or a squirrel...or maybe even a mix...imagine getting eaten by a ducksquirrel.");
            Console.ReadLine();
            Console.WriteLine("You probably feel really stupid for not waking up right now.");
            Console.ReadLine();
            Console.WriteLine("Sleepy Ending (1/12)");
        }
        else if (answer == "a")
        {
            //You choose to wake up
            Console.WriteLine("You wake up inside a basement that you suspect belongs to the infamous villain Old lady person");
            Console.WriteLine("also known as some random person who kidnapped you and that you suspect is some old lady because of no reason whatsoever.");
            Console.ReadLine();
            Console.WriteLine("You wonder how you could possibly escape from the awful pie baking monster.");
            Console.WriteLine("You should just give up and wonder about your life choices...");
            Console.WriteLine("OR you could use a lockpick you randomly found to break open the door or you could just wait for the perfect moment.");
            Console.ReadLine();
            Console.WriteLine("The choice is yours. A:lockpick B:wait C:invesigate");
            string answer2 = Console.ReadLine().ToLower();
            if (answer2 == "b")
            {
                //Waiting
                Console.WriteLine("You choose to wait for the perfect moment.");
                Console.ReadLine();
                Console.WriteLine("After around 65 years of waiting nothing has happened and you are now 80 years old and crazy and somehow not dead because of starvation.");
                Console.WriteLine("You did find something interesting though. During all these years you found a crystal of ancient gods bla bla bla.");
                Console.WriteLine("Do you use the crystal?A:Eat it B:Yes C:Makeshift nuclear bomb");
                string answer3 = Console.ReadLine().ToLower();
                if (answer3 == "a")
                {
                    //You just ate a very rare crystal
                    Console.WriteLine("For some reason you put the crystal in you mouth.");
                    Console.ReadLine();
                    Console.WriteLine("A few minutes go by but the you feel the power going through you veins. You no longer have control over your body");
                    Console.WriteLine("and you end up going on a rampage with these new powers although you don't mind since if theres no one else you just get free icecream");
                    Console.ReadLine();
                    Console.WriteLine("Free ice cream ending (2/12)");
                }
                else if (answer3 == "b")
                {
                    //Epic Ryan Reynolds anime battle B)
                    Console.WriteLine("You use the crystal and feel godlike power going trough your veins.");
                    Console.ReadLine();
                    Console.WriteLine("The house explodes and you can hear the doom music kick in. You see Old lady person and it seems like she also found a similar crystal.");
                    Console.ReadLine();
                    Console.WriteLine("Why are you doing this? You ask. Old lady person doesn't answer but to your suprise she takes her face of which actually was a mask and Old lady person is actually a super sexy man also known as Ryan Reynolds.");
                    Console.ReadLine();
                    Console.WriteLine("How will you defeat Ryan Reynolds?A:Wait B:Attack");
                    string answer4 = Console.ReadLine().ToLower();
                    if (answer4 == "a")
                    {
                        //You don't attack first
                        Console.WriteLine("Ryan Reynolds charges up his super sexy god powers and throws the first punch. You barely dodge his attack but he turns around a uses his super sexy laser eyes to turn you to ashes");
                        Console.ReadLine();
                        Console.WriteLine("Super sexy eyes ending (3/12)");
                    }
                    else if (answer4 == "b")
                    {
                        //You attack first
                        Console.WriteLine("You charge up your averege god powers and lounge forward. You try to punch him but suddenly stop.");
                        Console.ReadLine();
                        Console.WriteLine("You realise he's to sexy and by hitting him you will destroy his sexy body thus making you unable to do anything against him.");
                        Console.ReadLine();
                        Console.WriteLine("Ryan Reynolds uses his super sexy god powers to weaken you. You vision is turning black and the last thing you see is Ryan Reynolds super sexily towering over you and then you die because your body can't handle his super sexyness.");
                        Console.ReadLine();
                        Console.WriteLine("Super sexy Ryan Reynolds anime battle ending (4/12)");

                    }
                    else if (answer4 == "c")
                    {
                        //Avengers but better
                        Console.WriteLine("You use your not at all sexy godpowers to break time and space and choose the third choice.");
                        Console.ReadLine();
                        Console.WriteLine("The doom music gets louder and you use your powers to assemble the I.D.I.O.T.S(Consists of Smelly-man, Some guy, Below averege-man and Idiot-man(you)");
                        Console.ReadLine();
                        Console.WriteLine("If you don't know what it stands for it stands for Incapacitated Dumb Idiots Of Terrible Smell");
                        Console.ReadLine();
                        Console.WriteLine("You are all ready to lounge forward and attack but to your suprise Ryan Reynolds has super sexily disappeared.");
                        Console.ReadLine();
                        Console.WriteLine("You look around but can't see him anywhere. Suddenly the ground starts shaking and a massive super sexy Ryan Reynolds super sexily appears from the ground and roars super");
                        Console.Write("sexily.");
                        Console.WriteLine();
                        Console.ReadLine();
                        Console.WriteLine("You realise that Old lady person also known as some random person who kidnapped you and that you suspect is some old lady because of no reason whatsoever also known as");
                        Console.Write("Ryan Reynolds is also another infamous villian known as Above Averege-Man");
                        Console.WriteLine();
                        Console.ReadLine();
                        Console.WriteLine("Above Averege-Man also known as Ryan Reynolds charges up his above averege super sexy godpowers and oblitirates Smelly-man.");
                        Console.ReadLine();
                        Console.WriteLine("The three of you that are left all lounge towards Ryan Reynolds but he uses his above averegeness to delete Below averege-man.");
                        Console.ReadLine();
                        Console.WriteLine("There's no hope left and you all feel defeated now that two of you are dead but Some guy(You really have no idea who that guy is) increases the volume of his radio so you");
                        Console.Write("can hear the doom music amongst all this noice and you both charge forward.");
                        Console.WriteLine();
                        Console.ReadLine();
                        Console.WriteLine("You knew that there was only one way to defeat him. You use you powers to pull the sun towards you. Once the earth starts burning and basically everyone is dead you realise it wasn't actually such a good idea.");
                        Console.ReadLine();
                        Console.WriteLine("I.D.I.O.T.S assemble!!!(Secret ending 1/2)");
                    }
                    else
                    {
                        //You just stand there like an idiot
                        Console.WriteLine("Ryan Reynolds uses his super sexy super beam om super sexyness and obliterates you before you have a chance to react.");
                        Console.ReadLine();
                        Console.WriteLine("S.S.B.O.S.S(Not Really An Ending(5/9))");
                    }
                }
                else if (answer3 == "c")
                {
                    //Turns out you where the villian all along
                    Console.WriteLine("You make the bomb, but you're such a dumb idiot that it becomes a huge pink glitter bomb that explodes. The glitter spreads into the atmosphere and blocks out all sunlight. After a few days almost all life on earth has been eradicated and you have proudly taken the title as the new most feared super villian.");
                    Console.ReadLine();
                    Console.WriteLine("Glitterpocalypse Ending(8/12)");
                }
                else
                {
                    //Crystal go boom!
                    Console.WriteLine("The crystal explodes.");
                    Console.ReadLine();
                    Console.WriteLine("You somehow survive but the explosion has attracted the attention of very hostile Old lady aliens");
                    Console.ReadLine();
                    Console.WriteLine("A few hours go by and you are now the last human left. The rest has been turned into pies.");
                    Console.ReadLine();
                    Console.WriteLine("Old lady invasion (Not Really An Ending(3/9))");
                }
            }
            else if (answer2 == "a")
            {
                //Handy dandy multitool
                Console.WriteLine("You choose to use the lockpick that you found but before you get the chance to use it you realise its actually an inflatable chainsaw.");
                Console.ReadLine();
                Console.WriteLine("You use the inflatable chainsaw to blow up the door since it was a bomb too.");
                Console.ReadLine();
                Console.WriteLine("You know theres only one thing left to do and that is finding Old lady person and destroy this awful villian once and for all.");
                Console.ReadLine();
                Console.WriteLine($"You realise that you happen to be in a resturant and is shocked to see that its the famous Kentucky Fried {name}s");
                Console.WriteLine("What do you do with this knowledge?A:Use thunderbolt B:Search");
                string Thunderbolt = Console.ReadLine().ToLower();
                if (Thunderbolt == "a")
                {
                    //Got to catch them all
                    Console.WriteLine("For some reason you try to use thunderbolt but since you aren't pikachu you try to cut some electrical wires using your fingers and end up electricuting yourself");
                    Console.ReadLine();
                    Console.WriteLine("Pikachu ending (5/12)");
                }
                else if (Thunderbolt == "b")
                {
                    //Normal boring searching scene
                    Console.WriteLine("You start searching around in the area and accidentaly bump into an old lady. She turns around and you instantly recognise her.");
                    Console.ReadLine();
                    Console.WriteLine("There's no doubt about it. She is definetly maybe Old lady person.");
                    Console.ReadLine();
                    Console.WriteLine("What do you do?A:Attack her B:RUN!");
                    string oldlady = Console.ReadLine().ToLower();
                    if (oldlady == "a")
                    {
                        //Epic suprise
                        Console.WriteLine("You lounge forward ready to strike but Old lady person turns out to be ripped and has no trouble stopping you.");
                        Console.ReadLine();
                        Console.WriteLine("She pulls of her mask to reveal that she is actually some random person who kidnapped you and that you suspect is some old lady because of no reason whatsoever ");
                        Console.WriteLine("also known as Old lady person");
                        Console.ReadLine();
                        Console.WriteLine($"You gasp in suprise. How could this be? If only you had known. She putts you in the fryer and before you know it you have been turned into delicious fried {name} legs");
                        Console.ReadLine();
                        Console.WriteLine("Fried ending (6/12)");
                    }
                    else if (oldlady == "b")
                    {
                        //Crybaby
                        Console.WriteLine("You run away crying like the baby you are.");
                        Console.ReadLine();
                        Console.WriteLine("Crybaby ending(7/12)");
                    }
                    else if (oldlady == "Victory")
                    {
                        //Victory?
                        Console.WriteLine("You activate you secret chicken powers and use your secret chickenbeam. The corrosive chicken melts Old lady person and you stand victorious and is now known as The wierd chicken guy that nobody wants to be close to");
                        Console.ReadLine();
                        Console.WriteLine("Kentucky Fried DESTRUCTION!!! ending (Secret ending 2/2)");
                    }
                    else
                    {
                        //New sonic game
                        Console.WriteLine("Old lady person turns out to be ripped and super fast and smacks the shit out of you before you can react.");
                        Console.ReadLine();
                        Console.WriteLine("Lady McQueen(Not Really An Ending(6/9))");
                    }
                }
                else
                {
                    //Really thought this one through
                    Console.WriteLine("You just give up and die");
                    Console.ReadLine();
                    Console.WriteLine("I ran out of ideas(Not Really An Ending(4/9))");
                }
            }
            else if (answer2 == "c")
            {
                //Good thing you noticed that
                Console.WriteLine("You start looking around and see something strange. On the wall with very very big glowing red letters it says 'THE LOCKPICK IS AN INFLATABLE CHAINSAW!!!!!'");
                Console.ReadLine();
                Console.WriteLine("Can't belive you didn't see that before. You press on a big red button on the lockpick and it somehow turns into an inflatable chainsaw. 'Hell yeah' You think to yourself.");
                Console.ReadLine();
                Console.WriteLine("You try to figure out what to do next. A:Escape(seems kinda obvious) B:Open the secret labratory door that you didn't know was there C:Forget about the chainsaw and summon a demon.");
                string Chainsaw = Console.ReadLine().ToLower();
                if (Chainsaw == "a")
                {
                    Console.WriteLine("You use the inflatable chainsaw so saw you way through the cement wall since the door wouldn't open when you stared at it.");
                    Console.ReadLine();
                    Console.WriteLine("Once you have escaped the awful prison you realise theres only one thing left to to and by one thing you mean 3 things.");
                    Console.Write("A:True ending B:Stop this");
                    Console.WriteLine();
                    string escaped = Console.ReadLine().ToLower();
                    if (escaped == "a")
                    {
                        //Epic plottwist
                        Console.WriteLine("You see a portal open in front of you and suddenly doom music starts playing.");
                        Console.ReadLine();
                        Console.WriteLine("A super sexy man steps through the portal followed by a bunch of other dudes. 'Stop this right now' He says and you recognise him and everyone else.");
                        Console.ReadLine();
                        Console.WriteLine($"Infront of you stands a super sexy man known as Ryan Reynolds, a ripped Old lady that works at Kentucky Fried {name}s, a bunch of people from some hero gang called I.D.I.O.T.S");
                        Console.Write("and a suprising amount of copies of you.");
                        Console.WriteLine();
                        Console.ReadLine();
                        Console.WriteLine("You realise that the people standing before you are all from different choices you could have made in this story.");
                        Console.ReadLine();
                        Console.WriteLine("You suddenly feel angry and lounge forward. You punch a version of yourself in the face which makes him unconcious and you immidiatly turn around and karate kick two more");
                        Console.Write("versions of yourself.");
                        Console.WriteLine();
                        Console.ReadLine();
                        Console.WriteLine("'We are here to stop you before it's to late' super sexy Ryan Reynolds says. You don't know what he is talking about but suddenly a picture of the world burning flashes before your eyes. You choose to ignore it and instead attack a version of you that has a seemingly powerful crystal in his mouth.");
                        Console.ReadLine();
                        Console.WriteLine("You punch him in the stomach and grab the crystal. Super sexy Ryan Reynolds runs super sexily towards you shouting to the others to stop you but it's no use.");
                        Console.ReadLine();
                        Console.WriteLine("'You lost' you say and start laughing maniacally and feel the crystals powers running through your veins. You use your new found powers to make meteors rain down from the sky oblitirating your opponents. Once it's all over you carve a throne in one of the meteors and finally realise that you where the villian all along.");
                        Console.WriteLine("True Ending");
                    }
                    else if (escaped == "b")
                    {
                        Console.WriteLine("You realise you finally have a chance to end this and defeat Old lady person.");
                        Console.ReadLine();
                        Console.WriteLine("I won't go into detail but you used the inflatable chainsaw to break into Old lady persons headquarter and somehow turn this villian of pure evil into a pie...i don't think you really are the hero anymore.");
                        Console.ReadLine();
                        Console.WriteLine("What did you do? Ending(9/12)");
                    }
                    else
                    {
                        Console.WriteLine("Legend has it you're still standing there wondering what to do.");
                        Console.ReadLine();
                        Console.WriteLine("You probably died(Not Really An Ending(7/9)");
                    }
                }
                else if (Chainsaw == "b")
                {
                    Console.WriteLine("You run around jumping with joy now that you have found your new found toy when suddenly you step on a big red very obvious button by accident because you didn't see it.");
                    Console.ReadLine();
                    Console.WriteLine("A door opens up and reveals a giant mysterious lab full sciency stuff like sciencey stuff.");
                    Console.ReadLine();
                    Console.WriteLine("You see a control panel and go to it.");
                    Console.ReadLine();
                    Console.WriteLine("what do you do. A:Mega ultra epic laser of absolute destruction B:Initiate project P.I.E");
                    string PIE = Console.ReadLine();
                    if (PIE == "a")
                    {
                        Console.WriteLine("You press a big red button and a TV turns on. The TV is showing you some kind of contraption that is floating in space.");
                        Console.ReadLine();
                        Console.WriteLine("The thing on the screen turns on and it shoots out a giant very epic looking laser beam. You suddenly feel the room get warmer and a couple seconds after your body has been incinerated.");
                        Console.ReadLine();
                        Console.WriteLine("You never knew what hit you Ending(11/12)");
                    }
                    else if (PIE == "b")
                    {
                        Console.WriteLine("You press some random buttons and a TV turns on. a xbox controller is given to you ant the TV shows a mech with the letters");
                        Console.Write("P.I.A on it turns on. A speaker loudly says 'Initiating project P.I.E which stands for Problem Ignoring Experiment'");
                        Console.WriteLine();
                        Console.ReadLine();
                        Console.WriteLine("You use the xbox controller to controll the giant mech and you go on a rampage.");
                        Console.ReadLine();
                        Console.WriteLine("After a few hours of having some fun and destroying cities you feel something on you neck.");
                        Console.ReadLine();
                        Console.WriteLine("You start pulling on whatever is stuck in you neck but when you get it of you realise its a mask. You had been wearing a mask this entire time.");
                        Console.ReadLine();
                        Console.WriteLine("Theres only one person that is evil enough to trick you like this and you turn around and look in the mirror that suddenly appeared out of no where.");
                        Console.ReadLine();
                        Console.WriteLine("You almost get a heart attack. The face you see in the mirror which is actually you face is none other than the infamous villian Old lady person.");
                        Console.ReadLine();
                        Console.WriteLine("She had finally won. There's no way you can defeat this awful villian since it's litreally you.");
                        Console.ReadLine();
                        Console.WriteLine("Plottwist Ending(12/12");
                    }
                    else
                    {
                        Console.WriteLine("You completely ignore the control panel and instead go to some sort of glass casing that seems to contain a myserious lifeform that you have never seen before.");
                        Console.ReadLine();
                        Console.WriteLine("There's a sign on the casing saying 'Nuclear baby' which probably isn't anything dangerous. You realise this is the perfect time to test your inflatable chainsaw and saw open the glass casing.");
                        Console.ReadLine();
                        Console.WriteLine("Something immediatly jumps forward and lands on you face grabbing it tight. Jokes on them because you have prepared your self for this very moment by traing for 15 years which you did by reading");
                        Console.Write("'What to do when a nuclear baby attacks you in a secret lab in Old lady persons basement for beginners'. You carefully follow the steps in the book step 1:Go down on you knees step 2:Start crying because there's no way to escape this and you fate is sealed.");
                        Console.WriteLine();
                        Console.ReadLine();
                        Console.WriteLine("You should have found a better book (Not Really An Ending(9/9))");
                    }
                }
                else if (Chainsaw == "c")
                {
                    Console.WriteLine("You throw away the inflatable chainsaw which explodes because it was also a bomb and it just so happens that the explosion revealed a secret room");
                    Console.Write("containing everything you need to summon a demon including the 'Summoning demons for beginners' book.");
                    Console.WriteLine();
                    Console.ReadLine();
                    Console.WriteLine("You read the entire book which is just one page and then you begin the ritual. A demon appears and he just so happened to have baked a pie which you both eat.");
                    Console.ReadLine();
                    Console.WriteLine("The pie was delicious and all to late you realise it was poisoned and the demon was actually none other than Old lady person.");
                    Console.ReadLine();
                    Console.WriteLine("Best buddies Ending(10/12)");
                    
                }
                else
                {
                    Console.WriteLine("You look around and see some random dude standing next to you and narrating everything you do.");
                    Console.ReadLine();
                    Console.WriteLine("You get agitated since he didn't ask for permission and turn on the inflatable chainsaw. You lounge forward and oh wait i forgot im the narrator.");
                    Console.ReadLine();
                    Console.WriteLine("Hold on we can talk about this wait no STOP!!!");
                    Console.ReadLine();
                    Console.WriteLine("End of story(Not Really An Ending(8/9)");
                }
            }
            else
            {
                //Cringe
                Console.WriteLine($"Since you couldn't decide what to do you started googling on how to escape Old lady persons basement when you name is {name} but all you find is a link that says");
                Console.Write($"*10 reasons why {name} is cringe.");
                Console.WriteLine();
                Console.ReadLine();
                Console.WriteLine("You end up dying because it's to much for you to handle.");
                Console.ReadLine();
                Console.WriteLine("Emotional damage(Not Really An Ending(2/9))");
            }

        }
        else
        {
            //Who doesn't like good news?
            Console.WriteLine("Sooooooo...there are good news and bad news.");
            Console.ReadLine();
            Console.WriteLine("Good news: you didn't get eaten by something");
            Console.ReadLine();
            Console.WriteLine("Bad news...Rocks shaped like The Rock started falling from the sky and one of them crushed you so you died.");
            Console.ReadLine();
            Console.WriteLine("The Rock(Not Really An Ending(1/9))");
        }
    }
    Console.ReadLine();
    Console.WriteLine("Do you want to restart?A:Yes B:No");

    restart = Console.ReadLine().ToLower();
}