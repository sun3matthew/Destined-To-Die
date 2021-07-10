using UnityEngine;

// The code example shows how to implement a metronome that procedurally
// generates the click sounds via the OnAudioFilterRead callback.
// While the game is paused or suspended, this time will not be updated and sounds
// playing will be paused. Therefore developers of music scheduling routines do not have
// to do any rescheduling after the app is unpaused

[RequireComponent(typeof(AudioSource))]
public class AudioGlitch : MonoBehaviour
{
    private float[] store;
    private float counter;
    private int glitchRecorded;
    private int glitchAdded;
    private int repeatAmt;
    private int glitchLen;
    private int amtRepeat;
    private int randomRepeat;

    public int newAmtRepeat;
    void Start()
    {
        newAmtRepeat = 0;
        amtRepeat = newAmtRepeat;

        glitchLen = 9;
        repeatAmt = 0;
        counter = 0;
        store = new float[2048* glitchLen];
        randomRepeat = 5;
        glitchRecorded = 0;
        glitchAdded = 0;
        for (int i = 0; i < store.Length; i++)
            store[i] = 0;
    }
    void Update()
    {
        counter += Time.deltaTime;
    }
    void OnAudioFilterRead(float[] data, int channels)
    {
        if (counter > randomRepeat)
        {
            for (int i = 0; i < 2048; i++)
                store[2048 * glitchRecorded + i] = data[i];
            glitchRecorded++;
            if (glitchRecorded >= glitchLen)
            {
                for (int i = 0; i < 2048; i++)
                    store[i] *= i / 2048f;
                for (int i = 0; i < 2048; i++)
                    store[2048 * (glitchLen-1) + i] *= (2048-i)/2048f;
                if (newAmtRepeat != 0)
                    for (int i = 0; i < 2048; i++)
                        data[i] *= (2048 - i) / 2048f;
                repeatAmt = 0;
                counter = 0;
                randomRepeat = 5;
                glitchRecorded = 0;
                glitchAdded = 0;
                amtRepeat = newAmtRepeat;
            }
        }
        else
        {
            if (amtRepeat == 0)
                return;
            if (repeatAmt < amtRepeat)
            {
                if (data == null || store == null)
                    return;
                for (int i = 0; i < 2048; i++)
                    data[i] = store[2048 * glitchAdded + i];
                glitchAdded++;
                if (glitchAdded >= glitchLen)
                {
                    repeatAmt++;
                    glitchAdded = 0;
                }
            }else if(amtRepeat != 0 && repeatAmt == amtRepeat)
            {
                repeatAmt++;
                for (int i = 0; i < 2048; i++)
                    data[i] *= i / 2048f;
            }
        }
    }
}