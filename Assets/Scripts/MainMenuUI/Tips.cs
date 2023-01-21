using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tips : MonoBehaviour
{
    [SerializeField]
    private Text DiffText;
    // Start is called before the first frame update
    void Start()
    {
        LanguageLocalization<string[]> tipsLo = new LanguageLocalization<string[]>();
        tipsLo.addLanguage(new string[] {
        "Learn how to live from trial and error. I will assist you with more information, each time you see me.",
        "Make sure you go to school. Otherwise your satisfaction will decrease very fast.",
        "Bouncing Icons indicate the task to go much faster.",
        "The knife will increase your Instantaneous Happiness, but decrease happiness.",
        "Talking to someone constantly will better positive effects they have on you.",
        "Death Tolerance is influenced by Instantaneous Happiness.",
        "Happiness is heavily influenced by Satisfaction.",
        "Death is dependent only on Happiness and Death Tolerance.",
        "Your Art, Coding, Friendship and School values influence Satisfaction.",
        "Death Tolerance is somewhat influenced by Happiness.",
        "Your Art, Coding, Friendship and School values decrease naturally.",
        "Instantaneous Happiness is influenced by Happiness.",
        "Playing Games and Watching Videos can increase Instantatious Happiness.",
        "Listening to music will exacerbate Instantaneous Happiness.",
        "The amount of sleep you get effects your satisfaction.",
        "Happiness is influenced by Happiness Instantaneous Happiness is influnced by Instantaneous Happiness.\nSatisfaction is influenced by Satisfaction. Death Tolerance is influenced by Death Tolerance"
        }, 0);

        tipsLo.addLanguage(new string[] {
        "เรียนรู้การใช้ชีวิตจากการลองผิดลองถูก เลาจะช่วยให้ข้อมูลเพิ่มเติมทุกครั้งที่นายเจอเลานะ",
        "เอาให้แน่ใจว่านายเข้าเรียนเสมอ ไม่งั้นความพึงพอใจของนายจะลดลงอย่างรวดเร็ว",
        "ไอค่อนที่เด้งบ่งบอกว่าการใช้งานมันจะทำให้เวลาเดินเร็วขึ้น",
        "การใช้มีดจะทำให้เพิ่มความสุขชั่วขณะ แต่จะลดความสุขลง",
        "การพูดคุยกับใครสักคนอย่างต่อเนื่อง จะทำให้พวกเขามองนายในแง่บวกมากขึ้น",
        "ความอดทนต่อความตายนั้นได้รับอิทธิพลมาจากความสุขชั่วขณะ",
        "ความสุขนั้นได้รับอิทธิพลเป็นอย่างมากจากความพึงพอใจ",
        "ความตายนั้นขึ้นอยู่กับความสุขและความอดทนต่อความตายเท่านั้น",
        "ค่าความสามารถด้านศิลปะ ด้านการเขียนโค้ด มิตรภาพ และการเข้าเรียน มีอิทธิพลต่อความพึงพอใจ",
        "ความอดทนต่อความตายนั้นค่อนข้างได้รับอิทธิพลจากความสุข",
        "ค่าความสามารถด้านศิลปะ ด้านการเขียนโค้ด มิตรภาพ และการเข้าเรียน นั้นลดลงอย่างธรรมชาติเป็นปกติ",
        "ความสุขชั่วขณะนั้นได้รับอิทธิพลจากความสุข",
        "การเล่นเกมและการดูวิดิโอสามารถเพิ่มความสุขชั่วขณะได้",
        "การฟังเพลงนั้นจะทำให้ความสุขชั่วขณะรุนแรงขึ้น",
        "ปริมาณการหลับที่นายได้รับนั้นส่งผลต่อความพึงพอใจของนาย",
        "ความสุขได้รับอิทธิพลจากความสุข ความสุขชั่วขณะได้รับอิทธิพลจากความสุขชั่วขณะ\nความพึงพอใจได้รับอิทธิพลจากความพึงพอใจ ความอดทนต่อความตายได้รับอิทธิพลจากความอดทนต่อความตาย"
        }, 1);

        tipsLo.addLanguage(new string[] {
        "Apprends comment rester en vie au fil des essais et des erreurs. Je t'aiderais avec des informations, à chaque fois que tu me verras.",
        "Sois sûr d'aller à l'école. Sinon ta satisfaction va baisser très rapidement.",
        "Les icônes qui sautillent indiquent les tâches qui se font plus rapidement.",
        "Le couteau va accroître ton Bonheur Instantané, mais baisser le Bonheur.",
        "Parler à quelqu'un de manière répétée va améliorer l'effet positif que cela a sur toi.",
        "La Tolérance à la Mort est influencée par le Bonheur Instantané.",
        "Le Bonheur est fortement influencé par la Satisfaction.",
        "La Mort dépend uniquement du Bonheur et du Bonheur instantané.",
        "La valeur d'Art, Codage, Amitié et École baisse naturellement.",
        "Le Bonheur Instantané est influencé par le Bonheur.",
        "Jouer à des jeux et regarder des vidéos peut accroître le Bonheur Instantané.",
        "Écouter de la musique exacerbe fortement le Bonheur Instantané.",
        "La quantité de sommeil que tu parviens à avoir affecte ta satisfaction.",
        "Le Bonheur est influencé par le Bonheur, le Bonheur Instantané est influencé par le Bonheur instantané.\nLa Satisfaction est influencée par la Satisfaction. La Tolérance à la Mort est influencée par la Tolérance à la Mort"
        }, 2);
        for (int i = 0; i < PlayerPrefs.GetInt("CatPostcards", 16); i++)
            if (i < tipsLo.getLanguage().Length)
                DiffText.text += (i+1) + ": " + tipsLo.getLanguage()[i] + "\n";
    }

}
