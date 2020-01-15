using System;

namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on
            the branch?
            */

            // ### EXAMPLE:
            int initialNumberOfBirds = 4;
            int birdsThatFlewAway = 1;
            int remainingNumberOfBirds = initialNumberOfBirds - birdsThatFlewAway;

            /*
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests?
            */

            // ### EXAMPLE:
            int numberOfBirds = 6;
            int numberOfNests = 3;
            int numberOfExtraBirds = numberOfBirds - numberOfNests;

            /*
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods?
            */
            int raccoonsInitial = 3;
            int raccoonsLeftForDinner = 2;
            int raccoonsLeftInWoods = raccoonsInitial - raccoonsLeftForDinner;
            /*
            4. There are 5 flowers and 3 bees. How many less bees than flowers?
            */
            int flowers = 5;
            int bees = 3;
            int howManyMoreFlowers = flowers - bees;
            /*
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now?
            */
            int hungryLonelyPigeon = 1;
            int newPigeonFriend = 1;
            int pigeonsEatingBreadcrumbs = hungryLonelyPigeon + newPigeonFriend;
            /*
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now?
            */
            int initialOwlsOnFence = 2;
            int newlyArrivedOwls = 2;
            int totalOwlsOnFence = initialOwlsOnFence + newlyArrivedOwls;
            /*
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home?
            */
            int workingBeavers = 2;
            int swimmingBeavers = 1;
            int stillWorkingBeavers = workingBeavers - swimmingBeavers;
            /*
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all?
            */
            int initialToucansOnALimb = 2;
            int newToucan = 1;
            int totalToucansOnALimb = initialToucansOnALimb + newToucan;
            /*
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts?
            */
            int squirrels = 4;
            int nuts = 2;
            int moreSquirrelsThanNuts = squirrels - nuts;

            /*
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find?
            */
            double foundQuarter = .25;
            double foundDime = .10;
            double foundNickels = (2 * .05);
            double mrsHiltsMoney = foundQuarter + foundDime + foundNickels;

            /*
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all?
            */
            int muffinsBrierClass = 18;
            int muffinsMacAdamsClass = 20;
            int muffinsFlanneryClass = 17;
            int totalFirstGradeMuffins = muffinsBrierClass + muffinsMacAdamsClass + muffinsFlanneryClass;
            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */
            double costYoyo = .24;
            double costWhistle = .14;
            double spentOnToys = costYoyo + costWhistle;
            /*
            13. Mrs. Hilt made 5 Rice Krispie Treats. She used 8 large marshmallows
            and 10 mini marshmallows. How many marshmallows did she use
            altogether?
            */
            int largeMarshmallows = 8;
            int miniMarshmallows = 10;
            int totalMarshmallows = largeMarshmallows + miniMarshmallows;
            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */
            int inchesOfSnowAtHiltHouse = 29;
            int inchesOfSnowAtBrecknockSchool = 17;
            int inchesMoreSnowAtHiltHouse = inchesOfSnowAtHiltHouse - inchesOfSnowAtBrecknockSchool;
            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */
            int totalDollarsAvailable = 10;
            int costToyTruckInDollars = 3;
            int costPencilCaseInDollars = 2;
            int totalMoneyRemaining = totalDollarsAvailable - (costToyTruckInDollars + costPencilCaseInDollars);
            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */
            int originalMarbles = 16;
            int lostMarbles = 7;
            int remainingMarbles = originalMarbles - lostMarbles;
            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */
            int totalCurrentSeashells = 19;
            int totalDesiredSeashells = 25;
            int remainingSeashellsNeeded = totalDesiredSeashells - totalCurrentSeashells;
            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */
            int totalBalloons = 17;
            int redBalloons = 8;
            int greenBalloons = totalBalloons - redBalloons;
            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */
            int originalBooks = 38;
            int addedBooks = 10;
            int totalCurrentBooks = originalBooks + addedBooks;
            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */
            int numBees = 8;
            int numLegsPerBee = 6;
            int totalBeeLegs = numBees * numLegsPerBee;
            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */
            double costIceCreamCone = .99;
            double numIceCreamCones = 2;
            double totalIceCreamCost = numIceCreamCones * costIceCreamCone;
            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */
            int currentRocksForBorder = 64;
            int totalNeededRocksForBorder = 125;
            int remainingNeededRocksForBorder = totalNeededRocksForBorder - currentRocksForBorder;
            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */
            int numOriginalMarbles = 38;
            int numLostMarbles = 15;
            int numRemainingMarbles = numOriginalMarbles - numLostMarbles;
            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */
            int milesToConcert = 78;
            int milesDriven = 32;
            int milesRemaining = milesToConcert - milesDriven;
            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time did she spend shoveling snow?
            */
            int minutesSnowShovelingSaturdayMorning = 90;
            int minutesSnowShovelingSaturdayAfternoon = 45;
            int totalMinutesSnowShoveling = minutesSnowShovelingSaturdayMorning + minutesSnowShovelingSaturdayAfternoon;
            double totalHoursSnowShoveling = totalMinutesSnowShoveling / 60;
            /*
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */
            double hotDogsBought = 6;
            double hotDogsCost = .5;
            double totalHotDogsCost = hotDogsBought * hotDogsCost;

            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */
            int moneyAvailableInCents = 50;
            int costPencilInCents = 7;
            int pencilsAbleToPurchase = moneyAvailableInCents / costPencilInCents;
            /*
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */
            int totalButterfliesSeen = 33;
            int orangeButterflies = 20;
            int redButterflies = totalButterfliesSeen - orangeButterflies;
            /*
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */
            double dollarsGiven = 1;
            double costOfCandy = .54;
            double changeReceived = dollarsGiven - costOfCandy;

            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */
            int treesInBackyard = 13;
            int treesToPlant = 12;
            int totalTreesAfterPlanting = treesInBackyard + treesToPlant;
            /*
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */
            int daysToSeeGrandma = 2;
            int hoursInADay = 24;
            int hoursUntilSeeingGrandma = daysToSeeGrandma * hoursInADay;
            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */
            int numOfCousins = 4;
            int piecesOfGum = 5;
            int totalGumNeeded = numOfCousins * piecesOfGum;
            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */
            int amountAvailableInDollars = 3;
            int costCandyBarInDollars = 1;
            int remainingDollars = amountAvailableInDollars - costCandyBarInDollars;
            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */
            int numBoatsInLake = 5;
            int numPeoplePerBoat = 3;
            int totalPeopleInBoatsOnLake = numBoatsInLake * numPeoplePerBoat;
            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */
            int initialLegos = 380;
            int lostLegos = 57;
            int remaininglegos = initialLegos - lostLegos;
            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */
            int muffinsBaked = 35;
            int muffinsNeeded = 83;
            int muffinsLeftToBake = muffinsNeeded - muffinsBaked;
            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */
            int totalCrayonsWilly = 1400;
            int totalCrayonsLucy = 290;
            int howManyMoreCrayonsThanLucy = totalCrayonsWilly - totalCrayonsLucy;
            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */
            int numStickersPerPage = 10;
            int numPagesOfStickers = 22;
            int totalStickers = numStickersPerPage * numPagesOfStickers;
            /*
            39. There are 96 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */
            int availableCupcakes = 96;
            int totalChildren = 8;
            int numCupcakesPerChild = availableCupcakes / totalChildren;
            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies each, how many
            cookies will not be placed in a jar?
            */
            int totalGingerbreadCookies = 47;
            int numCookiesPerJar = 6;
            int cookiesWithoutAJar = totalGingerbreadCookies % numCookiesPerJar;
            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received and equal number of croissants,
            how many will be left with Marian?
            */
            int totalCroissantsForNeighbors = 59;
            int totalNeighbors = 8;
            int croissantsRemaining = totalCroissantsForNeighbors % totalNeighbors;
            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */
            int cookiesNeededAtOnce = 276;
            int cookiesPerTray = 12;
            int traysNeeded = cookiesNeededAtOnce / cookiesPerTray;
            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */
            int totalPretzelsMade = 480;
            int servingSize = 12;
            int totalServingsPerpared = totalPretzelsMade / servingSize;
            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */
            int totalLemonCupcakesBaked = 53;
            int lemonCupcakesLeftAtHome = 2;
            int lemonCupcakesPerBox = 3;
            int boxesOfCupCakesDistributed = (totalLemonCupcakesBaked - lemonCupcakesLeftAtHome) / lemonCupcakesPerBox;
            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */
            int carrotSticksPrepared = 74;
            int peopleServed = 12;
            int carrotSticksUneaten = carrotSticksPrepared % peopleServed;
            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */
            int combinedTeddyBears = 98;
            int allowableBearsPerShelf = 7;
            int filledShelves = combinedTeddyBears / allowableBearsPerShelf;
            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */
            int picturesPerAlbum = 20;
            int totalPictures = 480;
            int albumsNeeded = totalPictures / picturesPerAlbum;
            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */
            int totalTradingCards = 94;
            int maxCardsPerBox = 8;
            int totalBoxesFilled = totalTradingCards / maxCardsPerBox;
            int cardsInUnfilledBox = totalTradingCards % maxCardsPerBox;
            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */
            int totalBooks = 210;
            int availableShelves = 10;
            int totalBooksPerShelf = totalBooks / availableShelves;
            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */
            int croissantsBaked = 17;
            int totalGuests = 7;
            int croissantsPerGuest = croissantsBaked / totalGuests;
            /*
                CHALLENGE PROBLEMS
            */

            /*
            Bill and Jill are house painters. Bill can paint a 12 x 14 room in 2.15 hours, while Jill averages
            1.90 hours. How long will it take the two painter working together to paint 5 12 x 14 rooms?
            Hint: Calculate the hourly rate for each painter, combine them, and then divide the total walls in feet by the combined hourly rate of the painters.
            Challenge: How many days will it take the pair to paint 623 rooms assuming they work 8 hours a day?
            */

            /*Question For Instructor: Would it be better to make everything a double rather than combining int and double? */
            int minutesInAnHour = 60;
            double billFullRoomTime = 2.15;
            double billTimeInMinutes = (minutesInAnHour * billFullRoomTime);
            double billHourly = minutesInAnHour / billTimeInMinutes;
            double jillFullRoomTime = 1.90;
            double jillTimeInMinutes = minutesInAnHour * jillFullRoomTime;
            double jillHourly = minutesInAnHour / jillTimeInMinutes;
            double combinedHourly = billHourly + jillHourly;
            int fullRoomSquareFootage = 12 * 14;
            double timeToPaintOneRoomTogether = fullRoomSquareFootage / combinedHourly;
            double hoursToPaintFiveRoomsTogether = (int) (5 * timeToPaintOneRoomTogether) / 60;
            Console.WriteLine(hoursToPaintFiveRoomsTogether);
            int moreRoomsToPaint = 628;
            double paintALotMoreRoomsTogether = (int)(moreRoomsToPaint * timeToPaintOneRoomTogether) / 60;
            int workDay = 8;
            int numDaysToPaintMoreRooms = (int) paintALotMoreRoomsTogether / workDay;
            Console.WriteLine(numDaysToPaintMoreRooms);

            /*
            Create and assign variables to hold your first name, last name, and middle initial. Using concatenation,
            build an additional variable to hold your full name in the order of last name, first name, middle initial. The
            last and first names should be separated by a comma followed by a space, and the middle initial must end
            with a period.
            Example: "Hopper, Grace B."
            */
            string myFirstName = "Christina";
            string myLastName = "Rivera";
            string myMiddleInitial = "N";
            string myFullName = myLastName + ", " + myFirstName + " " + myMiddleInitial + ".";
            Console.WriteLine(myFullName);
            /*
            The distance between New York and Chicago is 800 miles, and the train has already travelled 537 miles.
            What percentage of the trip has been completed?
            Hint: The percent completed is the miles already travelled divided by the total miles.
            Challenge: Display as an integer value between 0 and 100 using casts.
            */
            double milesBetweenNewYorkAndChicago = 800;
            double milesTraveledByTrain = 537;
            double milesCalculated = (milesTraveledByTrain / milesBetweenNewYorkAndChicago) * 100;
            int percentageOfTripCompleted = (int)milesCalculated;
            Console.WriteLine(percentageOfTripCompleted);
        }
    }
}
