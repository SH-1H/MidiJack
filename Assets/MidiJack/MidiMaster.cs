//
// MidiJack - MIDI Input Plugin for Unity
//
// Copyright (C) 2013-2016 Keijiro Takahashi
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
namespace MidiJack
{
    public static class MidiMaster
    {
        // MIDI event delegates
        public static MidiDriver.NoteOnDelegate noteOnDelegate {
            get { return MidiDriver.Instance.noteOnDelegate; }
            set { MidiDriver.Instance.noteOnDelegate = value; }
        }

        public static MidiDriver.NoteOffDelegate noteOffDelegate {
            get { return MidiDriver.Instance.noteOffDelegate; }
            set { MidiDriver.Instance.noteOffDelegate = value; }
        }

        public static MidiDriver.KnobDelegate knobDelegate {
            get { return MidiDriver.Instance.knobDelegate; }
            set { MidiDriver.Instance.knobDelegate = value; }
        }

        public static MidiDriver.PitchBendDelegate pitchBendDelegate {
            get { return MidiDriver.Instance.pitchBendDelegate; }
            set { MidiDriver.Instance.pitchBendDelegate = value; }
        }
        public static MidiDriver.PolyAfterTouchDelegate polyAfterTouchDelegate {
            get { return MidiDriver.Instance.polyAfterTouchDelegate; }
            set { MidiDriver.Instance.polyAfterTouchDelegate = value; }
        }

        public static MidiDriver.ChannelAfterTouchDelegate channelAfterTouchDelegate {
            get { return MidiDriver.Instance.channelAfterTouchDelegate; }
            set { MidiDriver.Instance.channelAfterTouchDelegate = value; }
        }

        public static MidiDriver.ProgramChangeDelegate programChangeDelegate
        {
            get { return MidiDriver.Instance.programChangeDelegate; }
            set { MidiDriver.Instance.programChangeDelegate = value; }
        }

        public static MidiDriver.SystemMessageDelegate systemMessageDelegate
        {
            get { return MidiDriver.Instance.systemMessageDelegate; }
            set { MidiDriver.Instance.systemMessageDelegate = value; }
        }

        // Returns the key state (on: velocity, off: zero).
        public static float GetKey(MidiChannel channel, int noteNumber)
        {
            return MidiDriver.Instance.GetKey(channel, noteNumber);
        }

        public static float GetKey(int noteNumber)
        {
            return MidiDriver.Instance.GetKey(MidiChannel.All, noteNumber);
        }

        // Returns true if the key was pressed down in the current frame.
        public static bool GetKeyDown(MidiChannel channel, int noteNumber)
        {
            return MidiDriver.Instance.GetKeyDown(channel, noteNumber);
        }

        public static bool GetKeyDown(int noteNumber)
        {
            return MidiDriver.Instance.GetKeyDown(MidiChannel.All, noteNumber);
        }

        // Returns true if the key was released in the current frame.
        public static bool GetKeyUp(MidiChannel channel, int noteNumber)
        {
            return MidiDriver.Instance.GetKeyUp(channel, noteNumber);
        }

        public static bool GetKeyUp(int noteNumber)
        {
            return MidiDriver.Instance.GetKeyUp(MidiChannel.All, noteNumber);
        }

        // Provides the CC (knob) list.
        public static int[] GetKnobNumbers(MidiChannel channel)
        {
            return MidiDriver.Instance.GetKnobNumbers(channel);
        }

        public static int[] GetKnobNumbers()
        {
            return MidiDriver.Instance.GetKnobNumbers(MidiChannel.All);
        }

        // Returns the CC (knob) value.
        public static float GetKnob(MidiChannel channel, int knobNumber, float defaultValue = 0)
        {
            return MidiDriver.Instance.GetKnob(channel, knobNumber, defaultValue);
        }

        public static float GetKnob(int knobNumber, float defaultValue = 0)
        {
            return MidiDriver.Instance.GetKnob(MidiChannel.All, knobNumber, defaultValue);
        }

        // Returns pitch bend value. 
        public static float GetBend(MidiChannel channel)
        {
            return MidiDriver.Instance.GetBend(channel);
        }

        public static float GetBend()
        {
            return MidiDriver.Instance.GetBend(MidiChannel.All);
        }

        // Returns the after touch (polyphonic) pressure.
        public static float GetPolyAfterTouch(MidiChannel channel, int noteNumber)
        {
            return MidiDriver.Instance.GetPolyAfterTouch(channel, noteNumber);
        }

        public static float GetPolyAfterTouch(int noteNumber)
        {
            return MidiDriver.Instance.GetPolyAfterTouch(MidiChannel.All, noteNumber);
        }

        // Returns the after touch (channel) pressure.
        public static float GetChannelAfterTouch(MidiChannel channel)
        {
            return MidiDriver.Instance.GetChannelAfterTouch(channel);
        }

        public static float GetChannelAfterTouch()
        {
            return MidiDriver.Instance.GetChannelAfterTouch(MidiChannel.All);
        }

        // Returns program number.
        public static int GetProgramNumber(MidiChannel channel)
        {
            return MidiDriver.Instance.GetProgramNumber(channel);
        }

        public static int GetProgramNumber()
        {
            return MidiDriver.Instance.GetProgramNumber(MidiChannel.All);
        }

        // Returns system message.
        public static int GetSystemMessage()
        {
            return MidiDriver.Instance.GetSystemMessage();
        }


        public static void SendNoteOn(uint deviceID, MidiChannel channel, int noteNumber, float velocity)
        {
            MidiDriver.Instance.SendNoteOn(deviceID, channel, noteNumber, velocity);
        }

        public static void SendNoteOff(uint deviceID, MidiChannel channel, int noteNumber, float velocity)
        {
            MidiDriver.Instance.SendNoteOff(deviceID, channel, noteNumber, velocity);
        }

        public static void SendCC(uint deviceID, MidiChannel channel, int ccNumber, float value)
        {
            MidiDriver.Instance.SendCC(deviceID, channel, ccNumber, value);
        }

        public static void SendBend(uint deviceID, MidiChannel channel, float value)
        {
            MidiDriver.Instance.SendBend(deviceID, channel, value);
        }

        public static void SendPolyAfterTouch(uint deviceID, MidiChannel channel, int noteNumber, float pressure)
        {
            MidiDriver.Instance.SendPolyAfterTouch(deviceID, channel, noteNumber, pressure);
        }

        public static void SendChannelAfterTouch(uint deviceID, MidiChannel channel, float pressure)
        {
            MidiDriver.Instance.SendChannelAfterTouch(deviceID, channel, pressure);
        }

        public static void SendProgramChange(uint deviceID, MidiChannel channel, int number)
        {
            MidiDriver.Instance.SendProgramChange(deviceID, channel, number);
        }

        public static void SendSystemMessage(uint deviceID, int number)
        {
            MidiDriver.Instance.SendSystemMessage(deviceID, number);
        }

        public static void SendChannelMessage(uint deviceID, uint statusbyte, uint databyte)
        {
            MidiDriver.Instance.SendChannelMessage(deviceID, statusbyte, databyte);
        }

        public static void SendChannelMessage(uint deviceID, uint statusbyte, MidiChannel channel, uint databyte)
        {
            MidiDriver.Instance.SendChannelMessage(deviceID, statusbyte, channel, databyte);
        }

        public static void SendMessage(uint deviceID, uint message)
        {
            MidiDriver.Instance.SendMessage(deviceID, message);
        }
    }
}
