public partial class PipeLineDrawer : UserControl, Runnable {
    private const string spaces = "       ";

    private string currentLine = "";
    private string depedencyLine = "";


    public PipeLineDrawer() {
        InitializeComponent();
    }

    public void Run() {
        List<Instruction> instructions = new List<Instruction>();

        foreach (string line in source.Text.Split('\n')) {
            string tline = line.Trim();
            if (tline[0] == '#' || tline.Length == 0) continue;

            instructions.Add(new Instruction(tline));
        }

        Instruction prevInstruction = null;
        int indentation = 0;
        foreach (Instruction instruction in instructions) {
            currentLine = "";
            depedencyLine = "";

            bool forwarding = prevInstruction == null ? false : (instruction.regRead && prevInstruction.regWrite && instruction.rs.Contains(prevInstruction.rd));
            bool stall = forwarding && prevInstruction.memRead;

            square("IF");
            if (stall) {
                square("ID", square: "()");
            }
            square("ID");
            square("EX", forwarding ? @"\\" : null);
            square("M ");
            square("WB");

            string indentationSpaces = string.Concat(Enumerable.Repeat(spaces, indentation));

            print("     " + indentationSpaces + depedencyLine);
            print(extendInstruction(instruction.name) + indentationSpaces + currentLine);

            prevInstruction = instruction;
            indentation += stall ? 2 : 1;
        }

    }

    private void square(string phase, string dependancies = null, string square = "||") {
        currentLine += $"{square[0]}{square[0]}{phase}{square[1]}{square[1]} ";
        depedencyLine += dependancies == null ? spaces : dependancies;
    }

    private void print(string output, string end = "\r\n") {
        result.Text += output + end;
    }

    private string extendInstruction(string instruction, int len = 5) {
        return instruction + ":" + string.Concat(Enumerable.Repeat(" ", len - instruction.Length));
    }

}