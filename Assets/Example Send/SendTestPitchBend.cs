using UnityEngine;
using UnityEngine.UI;
using MidiJack;

public class SendTestPitchBend : MonoBehaviour { 

    public SendTestMIDIManager midiManager;
    public Dropdown midiOutSelector;
    public Slider bendSlider;
    
    void Awake()
    {
        bendSlider.onValueChanged.AddListener(PitchBend);
    }

    public void PitchBend(float value)
    {
        uint id = midiManager.MidiOutDevices[midiOutSelector.value].Id;
        MidiMaster.SendBend(id, MidiChannel.Ch1, value);
    }
}
