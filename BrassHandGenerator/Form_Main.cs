namespace BrassHandGenerator
{
    public partial class Form_Main : Form
    {
        public string versionNumber = "v1.0";

        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            LB_Version.Text = versionNumber;
        }

        private void BT_Generate_OnClick(object sender, EventArgs e)
        {
            TB_Output.Text = GenerateNewBrassHandOutput();
        }

        private string GenerateNewBrassHandOutput()
        {

            Random random = new Random();
            int choice = 0;

            string output = "Error";
            string text_start = "Do ya ever notice when";

            choice = random.Next(0, possibleActions.Length);
            string text_action = possibleActions[choice];

            string text_middle = "and your brass hand";

            choice = random.Next(0, possibleOutcomes.Length);
            string text_outcome = possibleOutcomes[choice];

            string text_space = " ";

            output = (text_start + text_space + text_action + text_space + text_middle + text_space + text_outcome);
            return output;
        }

        private string[] possibleActions =
        {
            "you're playing TTT",
            "you're fixing your car's old exhaust pipe",
            "you're shopping for chorizo at Aldi",
            "you're about to take a hit on your gravity bong",
            "you're on discord with the boys when Noah starts getting racist",
            "you're skanking to Drum and Bass with Ali in a dark room",
            "you're helping drunk Joel to bed",
            "you're getting destroyed at chess by Seb",
            "you're getting serenaded by Vinny",
            "you're discussing porn with Simon",
            "you're holding a disgusting angle at B with Koen",
            "you're trying to stop India from stealing your girlfriend",
            "you're watching the Arsenal game with Matt",
            "you're about to gank Hannah's lane",
            "you roll a natural 20 in DnD with Kurt",
            "you're a guest on the GOATs podcast with Sebek",
            "you're about to be banned from Discord by Josh",
            "you're looking up furry hentai on the internet",
            "you're winning against a child on Fifa",
            "you're washing yourself in shower",
            "you're confessing your love to a stranger",
            "you're about to land a goomba stomp",
            "you're in the queue for Fever",
            "you're playing violin for the Royal British Orchestra",
            "you're about the meet the president",
            "you're driving down the M5",
            "you're trying to start the BBQ",
            "you're committing tax fraud",
            "you're filing for divorce with your bitch wife",
            "you're performing open heart surgery",
            "you're about to go on stage and give the performance of a lifetime",
            "you're trying to open your can of Carling",
            "you're cooking a microwave meal in the microwave",
            "you're brushing your teeth",
            "you're riding a horse",
            "you're opening the door to your house",
            "you're fingering ya missus",
            "you're petting a dog",
            "you're writing your PHD thesis",
            "you're picking a lock",
            "you're appyling brass hand oil to your brass hand",
            "you're holding hands with your dad",
            "you're bench pressing 150KG",
            "you're tyring to crack an egg",
            "you're feeding the pigeons",
            "you're about to pull the trigger",
            "you're finger painting",
            "you're trying to order take away",
            "you're cleaning a toilet",
            "you're playing snooker",
            "you're about to save the last penalty for England in the world cup final",
            "you're about to pull the legendary sword Excalibur from the stone",
            "you really need to input this combo right",
            "you go to upsmash for the win",
            "you're trying to install windows on your Grandma's computer",
            "you're feeling particularly sexy today",
            "you're about bar chord for Seaside by the Kooks on guitar"
        };

        private string[] possibleOutcomes =
        {
            "just falls right off",
            "seizes up",
            "explodes",
            "catches fire",
            "gets all juicey",
            "becomes totally soaked",
            "starts grinding",
            "just feels right",
            "seems to be up to something",
            "starts acting strange",
            "gets all excited",
            "makes a fist",
            "moves on it's own accord",
            "becomes possessed by the spirit of our lord",
            "lashes out with immense strength",
            "performs a perfect upper cut",
            "breaks down",
            "needs oiling",
            "starts to lose it's shine",
            "needs repairs",
            "gets in the way",
            "does the job perfectly",
            "just gets it done",
            "falls apart",
            "gets all heavy",
            "looks sad",
            "looks happy about it",
            "feels evil",
            "is out for blood",
            "is covered in shit",
            "needs a good clean",
            "gets lost in the moment",
            "detaches from your arm",
            "gets recognised by the enemy",
            "gets questioned by your friends",
            "is pointed out by others",
            "fails",
            "gets really warm",
            "gets really heavy",
            "feels lighter",
            "falls to the floor",
            "makes a very racist hand gesture",
            "throws up gang signs",
            "makes you wish you didn't have it",
            "gets in the way",
            "just isn't feeling it today",
            "gets all sticky",
            "starts to smell",
            "needs a good clean",
            "starts giving you phatom pain"
        };
    }
}