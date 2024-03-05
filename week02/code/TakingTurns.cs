public static class TakingTurns {
    public static void Test() {
        // TODO Problem 1 - Run test cases and fix the code to match requirements
        // Test Cases

        // Test 1
        // Scenario: Create a queue with the following people and turns: Bob (2), Tim (5), Sue (3) and
        // run until the queue is empty
        // Expected Result: Bob, Tim, Sue, Bob, Tim, Sue, Tim, Sue, Tim, Tim
        Console.WriteLine("Test 1");
        var players = new TakingTurnsQueue();
        players.AddPerson("Bob", 2);
        players.AddPerson("Tim", 5);
        players.AddPerson("Sue", 3);
        // Console.WriteLine(players);    // This can be un-commented out for debug help
        while (players.Length > 0)
            players.GetNextPerson();
        // Defect(s) Found: 
        // 1. The current code simply lists the name of the person however many times they are in the queue.  
        // The requirement is to list the name of the person and then place them back in the queue.  
        // This is a circular queue.  The current code does not do this.  The code should be modified to 
        // place the person back in the queue after they are displayed.  The number of turns should be 
        // decremented by 1 each time the person is displayed.  If the number of turns is 0 or less, then 
        // the person should not be placed back in the queue.  The code should be modified to do this.
        // 2. The code lists the names in reverse order.


        Console.WriteLine("---------");

        // Test 2
        // Scenario: Create a queue with the following people and turns: Bob (2), Tim (5), Sue (3)
        // After running 5 times, add George with 3 turns.  Run until the queue is empty.
        // Expected Result: Bob, Tim, Sue, Bob, Tim, Sue, Tim, George, Sue, Tim, George, Tim, George
        Console.WriteLine("Test 2");
        players = new TakingTurnsQueue();
        players.AddPerson("Bob", 2);
        players.AddPerson("Tim", 5);
        players.AddPerson("Sue", 3);
        for (int i = 0; i < 5; i++) {
            players.GetNextPerson();
            // Console.WriteLine(players);
        }

        players.AddPerson("George", 3);
        // Console.WriteLine(players);
        while (players.Length > 0)
            players.GetNextPerson();

        // Defect(s) Found: 
        // 1. The current code does the same thing as in Test 1.  The code should be modified to place the 
        // person back in the queue after they are displayed.  The number of turns should be decremented by 1.
        // 2. The code lists the names in reverse order.

        Console.WriteLine("---------");

        // Test 3
        // Scenario: Create a queue with the following people and turns: Bob (2), Tim (Forever), Sue (3)
        // Run 10 times.
        // Expected Result: Bob, Tim, Sue, Bob, Tim, Sue, Tim, Sue, Tim, Tim
        Console.WriteLine("Test 3");
        players = new TakingTurnsQueue();
        players.AddPerson("Bob", 2);
        players.AddPerson("Tim", 0);
        players.AddPerson("Sue", 3);
        // Console.WriteLine(players);
        for (int i = 0; i < 10; i++) {
            players.GetNextPerson();
            // Console.WriteLine(players);
        }
        // Defect(s) Found: 
        // 1. The code lists the names in reverse order.
        // 2. The code lists the name of the person however many times they are in the queue, and once for Tim.
        // 3. Because it processes through the code 10 times, it lists "No one in the queue" 4 times.

        Console.WriteLine("---------");

         // Test 4
        // Scenario: Create a queue with the following people and turns: Tim (Forever), Sue (3)
        // Run 10 times.
        // Expected Result: Tim, Sue, Tim, Sue, Tim, Sue, Tim, Tim, Tim, Tim
        Console.WriteLine("Test 4");
        players = new TakingTurnsQueue();
        players.AddPerson("Tim", -3);
        players.AddPerson("Sue", 3);
        // Console.WriteLine(players);
        for (int i = 0; i < 10; i++) {
            players.GetNextPerson();
            // Console.WriteLine(players);
        }
        // Defect(s) Found: 
        // 1. The code lists the names in reverse order.
        // 2. The code lists the name of the person however many times they are in the queue, and once for Tim.
        // 3. Because it processes through the code 10 times, it lists "No one in the queue" 6 times.

        Console.WriteLine("---------");

        // Test 5
        // Scenario: Try to get the next person from an empty queue
        // Expected Result: Error message should be displayed
        Console.WriteLine("Test 5");
        players = new TakingTurnsQueue();
        players.GetNextPerson();
        // Defect(s) Found:
        // 1. No defects found.  The code works as expected. It displays "No one in the queue."
    }
}