/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;

namespace Chapter15
{
    public class Client
    {
        static void Main()
        {
            // Create a radio and its up/down command objects
            Radio radio = new Radio();
            radio.SwitchOn();
            IVoiceCommand volumeUpCommand = new VolumeUpCommand(radio);
            IVoiceCommand volumeDownCommand = new VolumeDownCommand(radio);

            // Create an electric window and its up/down command objects
            ElectricWindow window = new ElectricWindow();
            IVoiceCommand windowUpCommand = new WindowUpCommand(window);
            IVoiceCommand windowDownCommand = new WindowDownCommand(window);

            // Create a speech recogniser object
            SpeechRecogniser speechRecogniser = new SpeechRecogniser();
            speechRecogniser.SetCommands(volumeUpCommand, volumeDownCommand);
            Console.WriteLine("Speech recognition controlling the radio");
            speechRecogniser.HearUpSpoken();
            speechRecogniser.HearUpSpoken();
            speechRecogniser.HearUpSpoken();
            speechRecogniser.HearDownSpoken();

            speechRecogniser.SetCommands(windowUpCommand, windowDownCommand);
            Console.WriteLine("Speech recognition will now control the window");
            speechRecogniser.HearDownSpoken();
            speechRecogniser.HearUpSpoken();

            Console.Read();
        }
    }
}
