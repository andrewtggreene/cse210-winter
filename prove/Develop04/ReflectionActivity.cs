class ReflectionActivity : Activity{
    private List<string> _listOfPrompts;
    private List<string> _listOfQuestions;
    public ReflectionActivity(int duration): base(duration){
        _name = "Breathing Activity";
        _description = @"This activity will help you relax by walking your through 
        breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    private string GetRandomPrompt(){
        return "";
    }
    private string GetRandomQuestion(){
        return "";
    }
    private void DisplayPrompt(){

    }
    private void DisplayQuestion(){

    }
    public void RunReflectionActivity(){

    }
}