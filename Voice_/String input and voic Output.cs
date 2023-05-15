using System.Speech.Synthesis;

var speech = new SpeechSynthesizer();
speech.SetOutputToDefaultAudioDevice();
speech.Speak("");
Console.WriteLine();
Console.ReadKey();
