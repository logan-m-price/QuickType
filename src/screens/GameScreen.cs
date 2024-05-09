namespace QuickType.Screens {
    
    class GameScreen : IScreen {

        private QuickType master;
        private bool gamemodeIsSelected;
        private bool playbookIsSelected;

        public GameScreen(QuickType master) {

            this.master = master;
            gamemodeIsSelected = false;
            playbookIsSelected = false;

        }

        public void Show() {

            if (!gamemodeIsSelected) {

                Console.WriteLine("Starting Game...");
                Console.WriteLine();
                Console.WriteLine("Select a Gamemode:");
                Console.WriteLine();
                Console.WriteLine("     s -- Standard");
                Console.WriteLine();

            } else if (!playbookIsSelected) {

                Console.WriteLine("Starting Game...");
                Console.WriteLine();
                Console.WriteLine("Select a Playbook:");
                Console.WriteLine();

            }
            

        }

        public void ProcessCommand(string input) {

        }
    }
}