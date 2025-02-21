using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Sprite[] elemntal_spirte;
    public Image aura_img;
    public Image trigger_img;

    public Slider reaction_1;
    public Slider reaction_2;
    public Slider reaction_3;

    public Button elemntal_btn_1;
    public Button elemntal_btn_2;
    public Button elemntal_btn_4;

    public float elental_time;

    [HideInInspector]
    public ColorBlock pick_colorBlock;
    [HideInInspector]
    public ColorBlock non_colorBlock;

    public Image reaction_1_slide_img;
    public Image reaction_2_slide_img;
    public Image reaction_3_slide_img;

    float reaction_cooltime;

    public string reaction_elemntal_aura;
    public string reaction_elemntal_trigger;

    public TextMeshProUGUI reaction_text;
    public TextMeshProUGUI Reaction_Remain_Text;
    public TextMeshProUGUI gu_1;
    public TextMeshProUGUI gu_2;
    public TextMeshProUGUI gu_3;

    public Button exit_btn;

    public TextMeshProUGUI reaction_value_text;
    string power_value_text;
    void Start()
    {
        reaction_cooltime = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        //�����̵� �ʴ� ����
        if (reaction_1.value > 0)
        {
            reaction_1.value -= Time.deltaTime;
            gu_1.text = Mathf.Floor(reaction_1.value).ToString();
        }
        if (reaction_2.value > 0)
        {
            reaction_2.value -= Time.deltaTime;
            gu_2.text = Mathf.Floor(reaction_2.value).ToString();
        }
        if (reaction_3.value > 0)
        {
            reaction_3.value -= Time.deltaTime;
            gu_3.text = Mathf.Floor(reaction_3.value).ToString();
        }
        //���� �ð� ���� �� �̹��� �ʱ�ȭ
        if (reaction_1.value <= 0)
        {
            if (reaction_cooltime < 0)
            {
                reaction_elemntal_aura = null;
                aura_img.sprite = null;
                reaction_text.text = " ";
                reaction_value_text.text = " ";
                gu_1.text = "";
            }
        }
        if (reaction_2.value <= 0)
        {
            if (reaction_cooltime < 0)
            {
                reaction_elemntal_trigger = null;
                trigger_img.sprite = null;
                reaction_text.text = " ";
                gu_2.text = "";
            }
        }
        if(reaction_3.value <= 0){
            Reaction_Remain_Text.text = "������ ���� ����";
            gu_3.text = "";
        }

        if (reaction_1.value > 0 && reaction_2.value > 0) //���� ����
        {
            if (reaction_elemntal_aura == "Pyro")
            {
                switch (reaction_elemntal_trigger)
                {
                    case "Hydro":
                        reaction_1.value -= elental_time * 2f;
                        reaction_2.value = 0;
                        reaction_cooltime = 1f;
                        reaction_text.text = "����";
                        reaction_value_text.text = power_value_text + "* 2";
                        break;
                    case "Cryo":
                        reaction_1.value -= elental_time * 0.5f;
                        reaction_2.value = 0;
                        reaction_cooltime = 1f;
                        reaction_text.text = "����";
                        reaction_value_text.text = power_value_text + "* 0.5";
                        break;
                    case "Dendro":
                        reaction_3.value = reaction_1.value;
                        reaction_3_slide_img.color = new Color32(178, 34, 34, 255);
                        Reaction_Remain_Text.text = "����";
                        reaction_1.value -= elental_time * 1f;
                        reaction_2.value = 0;
                        reaction_cooltime = 1f;
                        reaction_text.text = "����";
                        reaction_value_text.text = power_value_text + "* 1";
                        break;
                    case "Electro":
                        reaction_1.value -= elental_time * 1f;
                        reaction_2.value = 0;
                        reaction_cooltime = 1f;
                        reaction_text.text = "����ȭ";
                        reaction_value_text.text = power_value_text + "* 1";
                        break;
                    case "Geo":
                        reaction_1.value -= elental_time * 0.5f;
                        reaction_2.value = 0;
                        reaction_cooltime = 1f;
                        reaction_text.text = "����ȭ";
                        reaction_value_text.text = power_value_text + "* 0.5";
                        break;
                    case "Anemo":
                        reaction_1.value -= elental_time * 0.5f;
                        reaction_2.value = 0;
                        reaction_cooltime = 1f;
                        reaction_text.text = "Ȯ��";
                        reaction_value_text.text = power_value_text + "* 0.5";
                        break;
                    case "Abyss":
                        reaction_1.value = 0;
                        reaction_2.value = 0;
                        reaction_cooltime = 1f;
                        reaction_text.text = "���� ����";
                        reaction_value_text.text = " 0";
                        break;
                }
            }

            if (reaction_elemntal_aura == "Hydro")
            {
                switch (reaction_elemntal_trigger)
                {
                    case "Pyro":
                        reaction_1.value -= elental_time * 0.5f;
                        reaction_2.value = 0;
                        reaction_cooltime = 1f;
                        reaction_text.text = "����";
                        reaction_value_text.text = power_value_text + "* 0.5";
                        break;
                    case "Cryo":
                        if(elental_time == 9.5f)
                        {
                            reaction_3.value = 12f;
                            reaction_3_slide_img.color = new Color32(70, 130, 180, 255);
                            Reaction_Remain_Text.text = "����";
                        }
                        else
                        {
                            reaction_3.value = 17f;
                            reaction_3_slide_img.color = new Color32(70, 130, 180, 255);
                            Reaction_Remain_Text.text = "����";
                        }
                        reaction_1.value -= elental_time * 1f;
                        reaction_2.value = 0;
                        reaction_cooltime = 1f;
                        reaction_text.text = "����";
                        reaction_value_text.text = power_value_text + "* 1";
                        break;
                    case "Dendro":
                        reaction_1.value -= elental_time * 2f;
                        reaction_2.value = 0;
                        reaction_cooltime = 1f;
                        reaction_text.text = "��ȭ";
                        reaction_value_text.text = power_value_text + "* 2";
                        break;
                    case "Electro":
                        reaction_1.value -= elental_time * 0.4f;
                        reaction_2.value = 0;
                        reaction_cooltime = 1f;
                        reaction_text.text = "����";
                        reaction_value_text.text = power_value_text + "* 0.4";
                        break;
                    case "Geo":
                        reaction_1.value -= elental_time * 0.5f;
                        reaction_2.value = 0;
                        reaction_cooltime = 1f;
                        reaction_text.text = "����ȭ";
                        reaction_value_text.text = power_value_text + "* 0.5";
                        break;
                    case "Anemo":
                        reaction_1.value -= elental_time * 0.5f;
                        reaction_2.value = 0;
                        reaction_cooltime = 1f;
                        reaction_text.text = "Ȯ��";
                        reaction_value_text.text = power_value_text + "* 0.5";
                        break;
                    case "Abyss":
                        reaction_1.value = 0;
                        reaction_2.value = 0;
                        reaction_cooltime = 1f;
                        reaction_text.text = "���� ����";
                        reaction_value_text.text = " 0";
                        break;
                }
            }

            if (reaction_elemntal_aura == "Cryo")
            {
                switch (reaction_elemntal_trigger)
                {
                    case "Pyro":
                        reaction_1.value -= elental_time * 2f;
                        reaction_2.value = 0;
                        reaction_cooltime = 1f;
                        reaction_text.text = "����";
                        reaction_value_text.text = power_value_text + "* 2";
                        break;
                    case "Hydro":
                        if (elental_time == 9.5f)
                        {
                            reaction_3.value = 12f;
                            reaction_3_slide_img.color = new Color32(70, 130, 180, 255);
                            Reaction_Remain_Text.text = "����";
                        }
                        else
                        {
                            reaction_3.value = 17f;
                            reaction_3_slide_img.color = new Color32(70, 130, 180, 255);
                            Reaction_Remain_Text.text = "����";
                        }
                        reaction_1.value -= elental_time * 1f;
                        reaction_2.value = 0;
                        reaction_cooltime = 1f;
                        reaction_text.text = "����";
                        reaction_value_text.text = power_value_text + "* 1";
                        break;
                    case "Dendro":
                        reaction_text.text = "��������";
                        break;
                    case "Electro":
                        reaction_1.value -= elental_time * 1f;
                        reaction_2.value = 0;
                        reaction_cooltime = 1f;
                        reaction_text.text = "������";
                        reaction_value_text.text = power_value_text + "* 1";
                        break;
                    case "Geo":
                        reaction_1.value -= elental_time * 0.5f;
                        reaction_2.value = 0;
                        reaction_cooltime = 1f;
                        reaction_text.text = "����ȭ";
                        reaction_value_text.text = power_value_text + "* 0.5";
                        break;
                    case "Anemo":
                        reaction_1.value -= elental_time * 0.5f;
                        reaction_2.value = 0;
                        reaction_cooltime = 1f;
                        reaction_text.text = "Ȯ��";
                        reaction_value_text.text = power_value_text + "* 0.5";
                        break;
                    case "Abyss":
                        reaction_1.value = 0;
                        reaction_2.value = 0;
                        reaction_cooltime = 1f;
                        reaction_text.text = "���� ����";
                        reaction_value_text.text = " 0";
                        break;
                }
            }

            if (reaction_elemntal_aura == "Dendro")
            {
                switch (reaction_elemntal_trigger)
                {
                    case "Pyro":
                        reaction_3.value = reaction_1.value;
                        reaction_3_slide_img.color = new Color32(178, 34, 34, 255);
                        Reaction_Remain_Text.text = "����";
                        reaction_1.value -= elental_time * 1f;
                        reaction_2.value = 0;
                        reaction_cooltime = 1f;
                        reaction_text.text = "����";
                        reaction_value_text.text = power_value_text + "* 1";
                        break;
                    case "Cryo":
                        reaction_text.text = "��������";
                        break;
                    case "Hydro":
                        reaction_1.value -= elental_time * 0.5f;
                        reaction_2.value = 0;
                        reaction_cooltime = 1f;
                        reaction_text.text = "��ȭ";
                        reaction_value_text.text = power_value_text + "* 0.5";
                        break;
                    case "Electro":
                        reaction_1.value -= elental_time * 1f;
                        reaction_2.value = 0;
                        reaction_cooltime = 1f;
                        reaction_text.text = "Ȱ��";
                        reaction_value_text.text = power_value_text + "* 1";
                        break;
                    case "Geo":
                        reaction_text.text = "��������";
                        break;
                    case "Anemo":
                        reaction_text.text = "��������";
                        break;
                    case "Abyss":
                        reaction_1.value = 0;
                        reaction_2.value = 0;
                        reaction_cooltime = 1f;
                        reaction_text.text = "���� ����";
                        reaction_value_text.text = " 0";
                        break;
                }
            }

            if (reaction_elemntal_aura == "Electro")
            {
                switch (reaction_elemntal_trigger)
                {
                    case "Pyro":
                        reaction_1.value -= elental_time * 1f;
                        reaction_2.value = 0;
                        reaction_cooltime = 1f;
                        reaction_text.text = "����ȭ";
                        reaction_value_text.text = power_value_text + "* 1";
                        break;
                    case "Cryo":
                        reaction_1.value -= elental_time * 1f;
                        reaction_2.value = 0;
                        reaction_cooltime = 1f;
                        reaction_text.text = "������";
                        reaction_value_text.text = power_value_text + "* 1";
                        break;
                    case "Dendro":
                        reaction_1.value -= elental_time * 1f;
                        reaction_2.value = 0;
                        reaction_cooltime = 1f;
                        reaction_text.text = "Ȱ��";
                        reaction_value_text.text = power_value_text + "* 1";
                        break;
                    case "Hydro":
                        reaction_1.value -= elental_time * 0.4f;
                        reaction_2.value = 0;
                        reaction_cooltime = 1f;
                        reaction_text.text = "����";
                        reaction_value_text.text = power_value_text + "* 0.4";
                        break;
                    case "Geo":
                        reaction_1.value -= elental_time * 0.5f;
                        reaction_2.value = 0;
                        reaction_cooltime = 1f;
                        reaction_text.text = "����ȭ";
                        reaction_value_text.text = power_value_text + "* 0.5";
                        break;
                    case "Anemo":
                        reaction_1.value -= elental_time * 0.5f;
                        reaction_2.value = 0;
                        reaction_cooltime = 1f;
                        reaction_text.text = "Ȯ��";
                        reaction_value_text.text = power_value_text + "* 0.5";
                        break;
                    case "Abyss":
                        reaction_1.value = 0;
                        reaction_2.value = 0;
                        reaction_cooltime = 1f;
                        reaction_text.text = "���� ����";
                        reaction_value_text.text = " 0";
                        break;
                }
            }

            if (reaction_elemntal_aura == "Abyss")
            {
                switch (reaction_elemntal_trigger)
                {
                    case "Pyro":
                        reaction_1.value = 0;
                        reaction_2.value = 0;
                        reaction_cooltime = 1f;
                        reaction_text.text = "�ɿ� ��";
                        reaction_value_text.text = "��� ��ġ ����";
                        reaction_3.value = 10f;
                        reaction_3_slide_img.color = new Color32(75, 0, 130, 255);
                        Reaction_Remain_Text.text = "��ȭ";
                        break;
                    case "Cryo":
                        reaction_1.value = 0;
                        reaction_2.value = 0;
                        reaction_cooltime = 1f;
                        reaction_text.text = "�ɿ� ����";
                        reaction_value_text.text = "��� ��ġ ����";
                        reaction_3.value = 10f;
                        reaction_3_slide_img.color = new Color32(75, 0, 130, 255);
                        Reaction_Remain_Text.text = "�ѱ�";
                        break;
                    case "Electro":
                        reaction_1.value = 0;
                        reaction_2.value = 0;
                        reaction_cooltime = 1f;
                        reaction_text.text = "�ɿ� ����";
                        reaction_value_text.text = "��� ��ġ ����";
                        reaction_3.value = 10f;
                        reaction_3_slide_img.color = new Color32(75, 0, 130, 255);
                        Reaction_Remain_Text.text = "����";
                        break;
                    case "Dendro":
                        reaction_1.value = 0;
                        reaction_2.value = 0;
                        reaction_cooltime = 1f;
                        reaction_text.text = "�ɿ� Ǯ";
                        reaction_value_text.text = "��� ��ġ ����";
                        reaction_3.value = 10f;
                        reaction_3_slide_img.color = new Color32(75, 0, 130, 255);
                        Reaction_Remain_Text.text = "����";
                        break;
                    case "Hydro":
                        reaction_1.value = 0;
                        reaction_2.value = 0;
                        reaction_cooltime = 1f;
                        reaction_text.text = "�ɿ� ��";
                        reaction_value_text.text = "��� ��ġ ����";
                        reaction_3.value = 10f;
                        reaction_3_slide_img.color = new Color32(75, 0, 130, 255);
                        Reaction_Remain_Text.text = "ħ��";
                        break;
                    case "Geo":
                        reaction_1.value = 0;
                        reaction_2.value = 0;
                        reaction_cooltime = 1f;
                        reaction_text.text = "�ɿ� ����";
                        reaction_value_text.text = "��� ��ġ ����";
                        reaction_3.value = 10f;
                        reaction_3_slide_img.color = new Color32(75, 0, 130, 255);
                        Reaction_Remain_Text.text = "�տ�";
                        break;
                    case "Anemo":
                        reaction_1.value = 0;
                        reaction_2.value = 0;
                        reaction_cooltime = 1f;
                        reaction_text.text = "�ɿ� �ٶ�";
                        reaction_value_text.text = "��� ��ġ ����";
                        reaction_3.value = 10f;
                        reaction_3_slide_img.color = new Color32(75, 0, 130, 255);
                        Reaction_Remain_Text.text = "ǳȭ";
                        break;
                }
            }
        }
        //Ű���带 ���� ���� ���� ����
            if (Input.GetKey(KeyCode.Keypad1))
            {
                Elemntal_btn_1_click();
            }
            if (Input.GetKey(KeyCode.Keypad2))
            {
                Elemntal_btn_2_click();
            }
            if (Input.GetKey(KeyCode.Keypad3))
            {
                Elemntal_btn_4_click();
            }

            reaction_cooltime -= Time.deltaTime;
    }
    //���� ���� ����
    public void Elemntal_btn_1_click()
    {
        elemntal_btn_1.colors = pick_colorBlock;
        elemntal_btn_2.colors = non_colorBlock;
        elemntal_btn_4.colors = non_colorBlock;

        elental_time = 9.5f;
        power_value_text = "1GU";
    }
    public void Elemntal_btn_2_click()
    {
        elemntal_btn_1.colors = non_colorBlock;
        elemntal_btn_2.colors = pick_colorBlock;
        elemntal_btn_4.colors = non_colorBlock;

        elental_time = 12f;
        power_value_text = "2GU";
    }
    public void Elemntal_btn_4_click()
    {
        elemntal_btn_1.colors = non_colorBlock;
        elemntal_btn_2.colors = non_colorBlock;
        elemntal_btn_4.colors = pick_colorBlock;

        elental_time = 17f;
        power_value_text = "4GU";
    }
    //���� ��ư Ŭ�� ��
    public void Pyro()
    {
        if(reaction_elemntal_aura == null && reaction_elemntal_trigger != "Pyro")
        {
            reaction_elemntal_aura = "Pyro";
            reaction_1.value = elental_time;
            reaction_1_slide_img.color = Color.red;
            aura_img.sprite = elemntal_spirte[4];
        }
        else if(reaction_elemntal_aura != null && reaction_elemntal_aura != "Pyro" && reaction_elemntal_trigger == null)
        {
            reaction_elemntal_trigger = "Pyro";
            reaction_2.value = elental_time;
            reaction_2_slide_img.color = Color.red;
            trigger_img.sprite = elemntal_spirte[4];
        }
        else if(reaction_elemntal_aura == "Pyro")
        {
            reaction_elemntal_aura = "Pyro";
            reaction_1.value = elental_time;
            reaction_1_slide_img.color = Color.red;
            aura_img.sprite = elemntal_spirte[4];
        }
        else if(reaction_elemntal_trigger == "Pyro")
        {
            reaction_elemntal_trigger = "Pyro";
            reaction_2.value = elental_time;
            reaction_2_slide_img.color = Color.red;
            trigger_img.sprite = elemntal_spirte[4];
        }
        else
        {

        }
    }
    public void Hydro()
    {
        if (reaction_elemntal_aura == null && reaction_elemntal_trigger != "Hydro")
        {
            reaction_elemntal_aura = "Hydro";
            reaction_1.value = elental_time;
            reaction_1_slide_img.color = Color.blue;
            aura_img.sprite = elemntal_spirte[0];
        }
        else if (reaction_elemntal_aura != null && reaction_elemntal_aura != "Hydro" && reaction_elemntal_trigger == null)
        {
            reaction_elemntal_trigger = "Hydro";
            reaction_2.value = elental_time;
            reaction_2_slide_img.color = Color.blue;
            trigger_img.sprite = elemntal_spirte[0];
        }
        else if (reaction_elemntal_aura == "Hydro")
        {
            reaction_elemntal_aura = "Hydro";
            reaction_1.value = elental_time;
            reaction_1_slide_img.color = Color.blue;
            aura_img.sprite = elemntal_spirte[0];
        }
        else if (reaction_elemntal_trigger == "Hydro")
        {
            reaction_elemntal_trigger = "Hydro";
            reaction_2.value = elental_time;
            reaction_2_slide_img.color = Color.blue;
            trigger_img.sprite = elemntal_spirte[0];
        }
        else
        {

        }
    }
    public void Cryo()
    {
        if (reaction_elemntal_aura == null && reaction_elemntal_trigger != "Cryo")
        {
            reaction_elemntal_aura = "Cryo";
            reaction_1.value = elental_time;
            reaction_1_slide_img.color = Color.cyan;
            aura_img.sprite = elemntal_spirte[5];
        }
        else if (reaction_elemntal_aura != null && reaction_elemntal_aura != "Cryo" && reaction_elemntal_trigger == null)
        {
            reaction_elemntal_trigger = "Cryo";
            reaction_2.value = elental_time;
            reaction_2_slide_img.color = Color.cyan;
            trigger_img.sprite = elemntal_spirte[5];
        }
        else if (reaction_elemntal_aura == "Cryo")
        {
            reaction_elemntal_aura = "Cryo";
            reaction_1.value = elental_time;
            reaction_1_slide_img.color = Color.cyan;
            aura_img.sprite = elemntal_spirte[5];
        }
        else if (reaction_elemntal_trigger == "Cryo")
        {
            reaction_elemntal_trigger = "Cryo";
            reaction_2.value = elental_time;
            reaction_2_slide_img.color = Color.cyan;
            trigger_img.sprite = elemntal_spirte[5];
        }
        else
        {

        }
    }
    public void Dendro()
    {
        if (reaction_elemntal_aura == null && reaction_elemntal_trigger != "Dendro")
        {
            reaction_elemntal_aura = "Dendro";
            reaction_1.value = elental_time;
            reaction_1_slide_img.color = Color.green;
            aura_img.sprite = elemntal_spirte[6];
        }
        else if (reaction_elemntal_aura != null && reaction_elemntal_aura != "Dendro" && reaction_elemntal_trigger == null)
        {
            reaction_elemntal_trigger = "Dendro";
            reaction_2.value = elental_time;
            reaction_2_slide_img.color = Color.green;
            trigger_img.sprite = elemntal_spirte[6];
        }
        else if (reaction_elemntal_aura == "Dendro")
        {
            reaction_elemntal_aura = "Dendro";
            reaction_1.value = elental_time;
            reaction_1_slide_img.color = Color.green;
            aura_img.sprite = elemntal_spirte[6];
        }
        else if (reaction_elemntal_trigger == "Dendro")
        {
            reaction_elemntal_trigger = "Dendro";
            reaction_2.value = elental_time;
            reaction_2_slide_img.color = Color.green;
            trigger_img.sprite = elemntal_spirte[6];
        }
        else
        {

        }
    }
    public void Electro()
    {
        if (reaction_elemntal_aura == null && reaction_elemntal_trigger != "Electro")
        {
            reaction_elemntal_aura = "Electro";
            reaction_1.value = elental_time;
            reaction_1_slide_img.color = new Color32(180,85,162,255);
            aura_img.sprite = elemntal_spirte[3];
        }
        else if (reaction_elemntal_aura != null && reaction_elemntal_aura != "Electro" && reaction_elemntal_trigger == null)
        {
            reaction_elemntal_trigger = "Electro";
            reaction_2.value = elental_time;
            reaction_2_slide_img.color = new Color32(180, 85, 162, 255);
            trigger_img.sprite = elemntal_spirte[3];
        }
        else if (reaction_elemntal_aura == "Electro")
        {
            reaction_elemntal_aura = "Electro";
            reaction_1.value = elental_time;
            reaction_1_slide_img.color = new Color32(180, 85, 162, 255);
            aura_img.sprite = elemntal_spirte[3];
        }
        else if (reaction_elemntal_trigger == "Electro")
        {
            reaction_elemntal_trigger = "Electro";
            reaction_2.value = elental_time;
            reaction_2_slide_img.color = new Color32(180, 85, 162, 255);
            trigger_img.sprite = elemntal_spirte[3];
        }
        else
        {

        }
    }
    public void Geo()
    {
        if (reaction_elemntal_aura == null && reaction_elemntal_trigger != "Geo")
        {

        }
        else if (reaction_elemntal_aura != null && reaction_elemntal_aura != "Geo" && reaction_elemntal_trigger == null)
        {
            reaction_elemntal_trigger = "Geo";
            reaction_2.value = elental_time;
            reaction_2_slide_img.color = new Color32(238, 196, 118, 255);
            trigger_img.sprite = elemntal_spirte[2];
        }
        else if (reaction_elemntal_aura == "Geo")
        {

        }
        else if (reaction_elemntal_trigger == "Geo")
        {
            reaction_elemntal_trigger = "Geo";
            reaction_2.value = elental_time;
            reaction_2_slide_img.color = new Color32(238, 196, 118, 255);
            trigger_img.sprite = elemntal_spirte[2];
        }
        else
        {

        }
    }
    public void Anemo()
    {
        if (reaction_elemntal_aura == null && reaction_elemntal_trigger != "Anemo")
        {

        }
        else if (reaction_elemntal_aura != null && reaction_elemntal_aura != "Anemo" && reaction_elemntal_trigger == null)
        {
            reaction_elemntal_trigger = "Anemo";
            reaction_2.value = elental_time;
            reaction_2_slide_img.color = new Color32(0, 166, 149, 255);
            trigger_img.sprite = elemntal_spirte[1];
        }
        else if (reaction_elemntal_aura == "Anemo")
        {

        }
        else if (reaction_elemntal_trigger == "Anemo")
        {
            reaction_elemntal_trigger = "Anemo";
            reaction_2.value = elental_time;
            reaction_2_slide_img.color = new Color32(0, 166, 149, 255);
            trigger_img.sprite = elemntal_spirte[1];
        }
        else
        {

        }
    }
    public void Abyss()
    {
        if (reaction_elemntal_aura == null && reaction_elemntal_trigger != "Abyss")
        {
            reaction_elemntal_aura = "Abyss";
            reaction_1.value = elental_time;
            reaction_1_slide_img.color = new Color32(75, 0, 130, 255);
            aura_img.sprite = elemntal_spirte[7];
        }
        else if (reaction_elemntal_aura != null && reaction_elemntal_aura != "Abyss" && reaction_elemntal_trigger == null)
        {
            reaction_elemntal_trigger = "Abyss";
            reaction_2.value = elental_time;
            reaction_2_slide_img.color = new Color32(75, 0, 130, 255);
            trigger_img.sprite = elemntal_spirte[7];
        }
        else if (reaction_elemntal_aura == "Abyss")
        {
            reaction_elemntal_aura = "Abyss";
            reaction_1.value = elental_time;
            reaction_1_slide_img.color = new Color32(75, 0, 130, 255);
            aura_img.sprite = elemntal_spirte[7];
        }
        else if (reaction_elemntal_trigger == "Abyss")
        {
            reaction_elemntal_trigger = "Abyss";
            reaction_2.value = elental_time;
            reaction_2_slide_img.color = new Color32(75, 0, 130, 255);
            trigger_img.sprite = elemntal_spirte[7];
        }
        else
        {

        }
    }

    public void ExitApp()
    {
        Application.Quit();
    }
}
