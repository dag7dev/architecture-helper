class Instruction {

    public readonly string name;

    public bool branch  = false;

    public bool regWrite   = false;
    public bool regRead    = false;
    public bool memWrite   = false;
    public bool memRead    = false;

    public string rd = null;
    public List<string> rs = new List<string>();


    public Instruction(string instructionText) {
        string[] instructionParts = parseInstruction(instructionText);
        name = instructionParts[0];

        //if this is a load instruction
        if (name[0] == 'L' && name != "LUI") {//LOAD
            regWrite = true;
            memRead = true;
            regRead = true;

            rd = instructionParts[1];
            rs.Add(extractRegister(instructionParts[2]));

        } else if (name[0] == 'B') {//BRANCH
            branch = true;
            regRead = true;

            rs.Add(instructionParts[1]);
            rs.Add(instructionParts[2]);

        } else if (name[0] == 'S' && name.Length == 2) {//SAVE
            memWrite = true;
            regRead = true;

            rs.Add(instructionParts[1]);
            rs.Add(extractRegister(instructionParts[2]));

        } else if (name[name.Length - 1] == 'I' && name.Substring(name.Length - 2) == "IW") {//IM
            regWrite = true;

            rd = instructionParts[1];
            if (name != "LUI") {
                rs.Add(instructionParts[2]);
            }
        } else if (name == "JAL") {
            rd = instructionParts[1];
        } else {
            regRead = true;
            regWrite = true;

            rd = instructionParts[1];
            rs.Add(instructionParts[2]);
            rs.Add(instructionParts[3]);
        }
    }

    private string extractRegister(string instructionPart) {
        if (instructionPart.Contains('(')) {
            int start = instructionPart.IndexOf("(") + 1;
            int length = instructionPart.IndexOf(")") - start;
            return instructionPart.Substring(start, length);
        }
        return instructionPart;
    }

    private string[] parseInstruction(string instructionText) {
        //spacing the ,
        instructionText = instructionText.Replace(',', ' ');

        //Removing doubleSpaces
        RegexOptions options = RegexOptions.None;
        Regex regex = new Regex("[ ]{2,}", options);
        instructionText = regex.Replace(instructionText, " ");

        //removing trailing/leading spaces + toLower
        string[] output = instructionText.Trim().ToLower().Split(' ');

        //uppercase on the instruction name
        output[0] = output[0].ToUpper();

        return output;
    }

}