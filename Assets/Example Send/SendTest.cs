using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Globalization;
using UnityEngine.UI;
using MidiJack;

public class SendTest : MonoBehaviour {
	public SendTestMIDIManager midiManager;
	public Dropdown midiOutSelector;
	public InputField message;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void OnValueChanged(int result){
	}

	public void SendMIDIOut() {
		uint id = midiManager.MidiOutDevices[ midiOutSelector.value ].Id;
		uint msg = (uint)int.Parse(message.text, NumberStyles.HexNumber);
		MidiMaster.SendMessage(id, msg);
	}

	public void SendMIDINote() {
		uint id = midiManager.MidiOutDevices[ midiOutSelector.value ].Id;
		int note = int.Parse(message.text, NumberStyles.HexNumber);
		MidiMaster.SendNoteOn(id, MidiJack.MidiChannel.Ch1, note, 0.8f);
		StartCoroutine(waitNoteOff(id, note));
	}

	private IEnumerator waitNoteOff(uint id, int note) {
		 yield return new WaitForSeconds (0.2f);
		 MidiMaster.SendNoteOff(id, MidiJack.MidiChannel.Ch1, note, 0.8f);
	}

    public void Send()
    {
        uint id = midiManager.MidiOutDevices[midiOutSelector.value].Id;
        int note = int.Parse(message.text, NumberStyles.HexNumber);

        MidiMaster.SendBend(id, MidiJack.MidiChannel.Ch1, 0.8f);
        MidiMaster.SendPolyAfterTouch(id, MidiJack.MidiChannel.Ch1, note, 0.8f);
        MidiMaster.SendChannelAfterTouch(id, MidiJack.MidiChannel.Ch1, 0.8f);
        MidiMaster.SendProgramChange(id, MidiJack.MidiChannel.Ch1, 15);
    }
}
