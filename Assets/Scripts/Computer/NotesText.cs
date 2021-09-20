using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesText : MonoBehaviour
{
    private MeshRenderer text;
    private SpriteRenderer parentSR;
    void Start()
    {
        text = GetComponent<MeshRenderer>();
        text.sortingLayerName = "7OSWindow";
        parentSR = transform.parent.GetComponent<SpriteRenderer>();
        LanguageLocalization<string> localization = new LanguageLocalization<string>();
        localization.addLanguage("This is another test\n\nOnline School 6am to 12pm\nRunning Practice at 12:30pm\n\nPasswords:\nEmail: NcAt3$%^\nMesg: NcAt3$%^asdf\nPortal: gHast341\n\nStudent ID: 5201229\nSSN: 260-02-1931\n\nRelationship Status: Single till I die\n\tAlso virgin for life...\n\nBut at least I have friends? Honestly\nbeing single is not bad.\n\nWhich is what a single person would say", 0);
        localization.addLanguage("นี่คืออีกแบบทดสอบ\n\nเรียนออนไลน์ตอน 6am ถึง 12pm\nซ้อมวิ่งตอน  12:30pm\n\nรหัส:\nEmail: NcAt3$%^\nMesg: NcAt3$%^asdf\nPortal: gHast341\n\nStudent ID: 5201229\nSSN: 260-02-1931\n\nสถานะความสัมพันธ์: เป็นโสดจนวันตาย\n\tแล้วก็เวอร์จิ้นไปทั้งชีวิต...\n\nแต่อย่างน้อยฉันก็มีเพื่อนแหละนะ? จริงๆ แล้ว\nการเป็นโสดก็ไม่ได้แย่อะไรนี่\n\nนี่แหละคือสิ่งที่คนโสดมักจะพูดหล่ะ", 1);
        localization.addLanguage("Ceci est un autre test\n\nCours en ligne de 6h à 12h\nEntraînement à la course à 12h30\n\nMot de passe:\nEmail: NcAt3$%^\nMesg: NcAt3$%^asdf\nPortail: gHast341\n^nID d'Étudiant: 5201229\nSSN: 260-02-1931\n\nÉtat Relationnel: Célibataire jusqu'à ce\nque je meurs\n\nAussi vierge à vie...\n\nMais au moins j'ai des amis? Honnêtement\nêtre célibataire c'est pas mal.\n\nC'est ce qu'une personne célibataire dirait.", 2);
        GetComponent<TextMesh>().text = localization.getLanguage();
    }
    private void Update()
    {
        text.sortingOrder = parentSR.sortingOrder + 1;
    }
}
