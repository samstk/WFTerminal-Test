using Renci.SshNet;
using Renci.SshNet.Sftp;
using WFTerminal;

namespace TerminalTest
{
    public partial class ShellForm : Form
    {
        public ShellForm()
        {
            InitializeComponent();
        }

        public SshClient? Client;
        public MemoryStream? ExtendedStream;

        private void Form1_Load(object sender, EventArgs e)
        {
            string sshServer = "127.0.0.1";
            string sshUser = "samst";
            PrivateKeyFile privateKeyFile = new PrivateKeyFile("id_ed25519", null);

            // Test 1 : Redirect Shell Stream (Limited Support)
            Client = new SshClient(sshServer, sshUser, privateKeyFile);
            Client.Connect();
            ExtendedStream = new MemoryStream();
            ShellStream stream = Client.CreateShellStream("ssh-test", terminal1.Columns, terminal1.Rows, (uint)terminal1.Width, (uint)terminal1.Height, 4096);
            terminal1.SetSystemStream(stream);

            // We will just write our export TERM=linux to the stream directly.
            stream.Write("export TERM=linux\n");

            // Note that full ANSI is currently not supported and apps like vim will break.

            // Test 2 : Basic Writing
            terminal2.WriteLine("Hello World!");
            terminal2.Write("Please write a command to send to console: ");
            terminal2.ReadLine(text =>
            {
                stream.Write(text + "\n");
                terminal2.Write("Press any key to continue.");
                terminal2.ReadKeyEvent(args =>
                {
                    Client.Disconnect();
                    terminal1.SetSystemStream(null);
                    terminal1.WriteLine("SSH connection has been closed.");
                });
            });
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            Client?.Dispose();
            base.OnFormClosed(e);
        }
    }
}