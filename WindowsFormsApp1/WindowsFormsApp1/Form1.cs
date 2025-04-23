using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string _inputString;
        private int _offset;
        private string _encodedResult;

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Set the InputString and Offset properties
                _inputString = Textinput.Text;
                _offset = Convert.ToInt32(N.Text);

                // Transform the input string using the Encode method
                _encodedResult = Encode(_inputString, _offset);

                // Notify the user that the encoding is complete
                MessageBox.Show("Encoding complete. Click 'Print' to display the result.",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle any unexpected exceptions
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string Encode(string input, int offset)
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in input)
            {
                int asciiValue = (char)((c - 'A' + offset + 26) % 26 + 'A');
                result.Append((char)asciiValue);
            }
            return result.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_encodedResult))
            {
                // Display the stored encoded result in the Textanswer label
                Textanswer.Text = _encodedResult;
            }
            else
            {
                // Notify the user that no encoding has been performed yet
                MessageBox.Show("No encoded result available. Please click 'Encode' first.",
                                "No Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Sortb_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Get the input string from the Textinput TextBox
                string input = Textinput.Text;

                // Validate that the input is not empty
                if (string.IsNullOrWhiteSpace(input))
                {
                    MessageBox.Show("Please enter a valid input string.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Sort the input string alphabetically
                string sortedInput = new string(input.OrderBy(c => c).ToArray());

                // Display the sorted result in the Sort label
                Sort.Text = $"Sort = \"{sortedInput}\"";
            }
            catch (Exception ex)
            {
                // Handle any unexpected errors
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayAsciiInListBox(string input)
        {
            // Clear the listBox1 before adding new items
            ASCII.Items.Clear();

            // Convert each character to its ASCII code and add to the listBox1
            foreach (char c in input)
            {
                ASCII.Items.Add($"{c} -> {((int)c)}");
            }
        }

        private void Inputcode_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Get the input string from the Textinput TextBox
                string input = Textinput.Text;

                // Call the DisplayAsciiInListBox function to show ASCII codes in listBox1
                DisplayAsciiInListBox(input);
            }
            catch (Exception ex)
            {
                // Handle any unexpected errors
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Outputcode_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Get all items from listBox1 and concatenate them into a single string
                string output = string.Join(Environment.NewLine, ASCII.Items.Cast<string>());

                // Display the concatenated string in a MessageBox
                MessageBox.Show(output, "ASCII Codes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle any unexpected errors
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class StringEncoder
    {
        private string _inputString;
        private int _offset;

        // Property for InputString with validation
        public string InputString
        {
            get => _inputString;
            set
            {
                if (!string.IsNullOrEmpty(value) && value.All(char.IsUpper) && value.Length <= 40)
                {
                    _inputString = value;
                }
                else
                {
                    throw new ArgumentException("Input string must contain only capital letters (A-Z) and be at most 40 characters long.");
                }
            }
        }

        // Property for Offset with validation
        public int Offset
        {
            get => _offset;
            set
            {
                if (value >= -25 && value <= 25)
                {
                    _offset = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Offset must be between -25 and 25.");
                }
            }
        }

        // Method to encode the input string
        public string Encode()
        {
            if (string.IsNullOrEmpty(_inputString))
            {
                throw new InvalidOperationException("Input string is not set.");
            }

            StringBuilder result = new StringBuilder();
            foreach (char c in _inputString)
            {
                int asciiValue = (char)((c - 'A' + _offset + 26) % 26 + 'A');
                result.Append((char)asciiValue);
            }
            return result.ToString();
        }

        // Method to get ASCII representation of the input string
        public string[] GetAsciiArray()
        {
            if (string.IsNullOrEmpty(_inputString))
            {
                throw new InvalidOperationException("Input string is not set.");
            }

            return _inputString.Select(c => $"{c} -> {((int)c)}").ToArray();
        }
    }

    public class StringProcessing
    {
        private string _inputString;
        private int _offset;

        // Property for InputString with validation
        public string InputString
        {
            get => _inputString;
            set
            {
                if (!string.IsNullOrEmpty(value) && value.All(char.IsUpper) && value.Length <= 40)
                {
                    _inputString = value;
                }
                else
                {
                    throw new ArgumentException("Input string must contain only capital letters (A-Z) and be at most 40 characters long.");
                }
            }
        }

        // Property for Offset with validation
        public int Offset
        {
            get => _offset;
            set
            {
                if (value >= -25 && value <= 25)
                {
                    _offset = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Offset must be between -25 and 25.");
                }
            }
        }

        // Method to encode the input string
        public string Encode()
        {
            if (string.IsNullOrEmpty(_inputString))
            {
                throw new InvalidOperationException("Input string is not set.");
            }

            StringBuilder result = new StringBuilder();
            foreach (char c in _inputString)
            {
                int asciiValue = (char)((c - 'A' + _offset + 26) % 26 + 'A');
                result.Append((char)asciiValue);
            }
            return result.ToString();
        }

        // Method to sort the input string alphabetically
        public string SortString()
        {
            if (string.IsNullOrEmpty(_inputString))
            {
                throw new InvalidOperationException("Input string is not set.");
            }

            return new string(_inputString.OrderBy(c => c).ToArray());
        }

        // Method to get ASCII representation of the input string
        public string[] GetAsciiArray()
        {
            if (string.IsNullOrEmpty(_inputString))
            {
                throw new InvalidOperationException("Input string is not set.");
            }

            return _inputString.Select(c => $"{c} -> {((int)c)}").ToArray();
        }

        public static void Main(string[] args)
        {
            try
            {
                // Test 1: Encode and Decode
                Console.WriteLine("Enter input string (capital letters only, max 40 characters):");
                string inputString = Console.ReadLine();
                Console.WriteLine("Enter offset value (-25 to 25):");
                int offset = int.Parse(Console.ReadLine());

                // Instantiate the StringProcessing class
                StringProcessing processor = new StringProcessing
                {
                    InputString = inputString,
                    Offset = offset
                };

                // Encode the input string
                string encodedResult = processor.Encode();
                Console.WriteLine($"Encoded Result: {encodedResult}");

                // Decode the encoded result
                processor.InputString = encodedResult;
                processor.Offset = -offset; // Reverse the offset
                string decodedResult = processor.Decode();
                Console.WriteLine($"Decoded Result: {decodedResult}");

                // Verify if the decoded result matches the original input
                Console.WriteLine(decodedResult == inputString
                    ? "Test Passed: Decoded result matches the original input."
                    : "Test Failed: Decoded result does not match the original input.");

                // Test 2: Sort the input string
                processor.InputString = inputString; // Reset to original input
                string sortedResult = processor.SortString();
                Console.WriteLine($"Sorted Result: {sortedResult}");

                // Test 3: Get ASCII representation
                string[] asciiArray = processor.GetAsciiArray();
                Console.WriteLine("ASCII Codes:");
                foreach (string ascii in asciiArray)
                {
                    Console.WriteLine(ascii);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
    }

