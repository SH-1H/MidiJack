using UnityEngine;
using System.Globalization;
using UnityEngine.UI;
using MidiJack;

public class SendTestMessage : MonoBehaviour{

    public SendTestMIDIManager midiManager;
    public Dropdown midiOutSelector;
    public InputField number;

    public void SendProgramChange()
    {
        uint id = midiManager.MidiOutDevices[midiOutSelector.value].Id;
        int num = int.Parse(number.text, NumberStyles.HexNumber);
        MidiMaster.SendProgramChange(id, MidiChannel.Ch1, num);
    }

    public void SendSystemMessage(int value)
    {
        uint id = midiManager.MidiOutDevices[midiOutSelector.value].Id;
        MidiMaster.SendSystemMessage(id, value);
    }
}
