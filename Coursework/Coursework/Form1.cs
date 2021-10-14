using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Coursework
{

    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        public string FilePlace = "Places.txt";
        public string FileFilms = "Films.txt";
        public string Saves = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        public string Folder = "/CinemaData";
        public StreamWriter PlaceWrite;
        public StreamReader PlaceRead;
        public StreamWriter FilmsWrite;
        public StreamReader FilmsRead;
        public string placereserv = "";
        public string filmsreserv = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(Saves + Folder))
            {
                Directory.CreateDirectory(Saves + Folder);
                MessageBox.Show("Была создана папка \"CinemaData\" на рабочем столе для сохранения данных! Пожалуйста, не изменяйте данные внутри, чтобы избежать их повреждения", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }

            Folder += "/";

            string ReaderKey;
            string Word;
            int Index;
            string keeey;
            uint sumkey;
            bool Check = false;

            if (File.Exists(Saves + Folder + FilePlace))
            {
                try
                {
                    PlaceRead = new StreamReader(Saves + Folder + FilePlace, true);
                    while (!PlaceRead.EndOfStream)
                    {
                        ReaderKey = PlaceRead.ReadLine();
                        place += ReaderKey + " ";
                        placereserv += ReaderKey + " ";

                        Index = ReaderKey.IndexOf("-");
                        Word = ReaderKey.Substring(0, Index);
                        keeey = Word;

                        if (Word.Substring(0, 1) == "0")
                            Word = "";

                        sumkey = uint.Parse(Word);
                        comboBoxHallPD.Items.Add(Word);
                        ReaderKey = ReaderKey.Remove(0, Index + 1);

                        Index = ReaderKey.IndexOf("-");
                        Word = ReaderKey.Substring(0, Index);
                        keeey += Word;

                        if (Word.Substring(0, 1) == "0")
                            Word = "";

                        sumkey += uint.Parse(Word);
                        comboBoxRowPD.Items.Add(Word);
                        ReaderKey = ReaderKey.Remove(0, Index + 1);

                        keeey += ReaderKey;

                        if (ReaderKey.Substring(0, 1) == "0")
                            ReaderKey = "";

                        sumkey += uint.Parse(ReaderKey);
                        comboBoxPlacePD.Items.Add(ReaderKey);

                        bool check = node.CheckPlace(uint.Parse(keeey), MiddleSquare(sumkey));
                        if (check == false)
                            sumkey = uint.Parse("");
                        else
                            node.AddPlace(uint.Parse(keeey), MiddleSquare(sumkey));
                    }
                    PlaceRead.Close();
                    File.Delete(Saves + Folder + FilePlace);
                    Check = true;
                }
                catch(Exception)
                {
                    MessageBox.Show("Произошла ошибка чтения файлов! Файлы были повреждены, а дынные утеряны", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    PlaceRead.Close();
                    File.Delete(Saves + Folder + FilePlace);
                    File.Delete(Saves + Folder + FileFilms);
                    checksave = true;
                    this.Close();
                }
            }

            if (File.Exists(Saves + Folder + FileFilms) && Check == true)
            {
                try
                {
                    string flm;
                    FilmsRead = new StreamReader(Saves + Folder + FileFilms, true);
                    while (!FilmsRead.EndOfStream)
                    {
                        ReaderKey = FilmsRead.ReadLine();
                        films += ReaderKey + ",";
                        filmsreserv += ReaderKey + ","; 

                        Index = ReaderKey.IndexOf("_");
                        Word = ReaderKey.Substring(0, Index);
                        flm = Word;
                        ReaderKey = ReaderKey.Remove(0, Index + 1);

                        Index = ReaderKey.IndexOf("-");
                        Word = ReaderKey.Substring(0, Index);
                        keeey = Word;

                        if (Word.Substring(0, 1) == "0")
                            Word = "";

                        sumkey = uint.Parse(Word);
                        comboBoxHallRes.Items.Add(Word);
                        ReaderKey = ReaderKey.Remove(0, Index + 1);

                        Index = ReaderKey.IndexOf("-");
                        Word = ReaderKey.Substring(0, Index);
                        keeey += Word;

                        if (Word.Substring(0, 1) == "0")
                            Word = "";

                        sumkey += uint.Parse(Word);
                        comboBoxRowRes.Items.Add(Word);
                        ReaderKey = ReaderKey.Remove(0, Index + 1);

                        keeey += ReaderKey;

                        if (ReaderKey.Substring(0, 1) == "0")
                            ReaderKey = "";

                        sumkey += uint.Parse(ReaderKey);
                        comboBoxPlaceRes.Items.Add(ReaderKey);

                        bool check = node.CheckPlace(uint.Parse(keeey), MiddleSquare(sumkey));
                        string str = root.Find(root, new LinkedList.Films("", uint.Parse(keeey)));
                        if (check == false && str == "")
                            root = root.Insert(root, new LinkedList.Films(flm, uint.Parse(keeey)));
                        else
                            sumkey = uint.Parse("");
                    }
                    FilmsRead.Close();
                    File.Delete(Saves + Folder + FileFilms);
                }
                catch (Exception)
                {
                    MessageBox.Show("Произошла ошибка чтения файлов! Файлы были повреждены, а дынные утеряны", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    FilmsRead.Close();
                    File.Delete(Saves + Folder + FileFilms);
                    File.Delete(Saves + Folder + FilePlace);
                    checksave = true;
                    this.Close();
                }
            }
        }

        private void забронироватьБилетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxFilms.Visible = true;
            textBoxHall.Visible = true;
            textBoxPlace.Visible = true;
            textBoxRow.Visible = true;

            comboBoxHallPD.Visible = false;
            comboBoxRowPD.Visible = false;
            comboBoxPlacePD.Visible = false;
            comboBoxHallRes.Visible = false;
            comboBoxRowRes.Visible = false;
            comboBoxPlaceRes.Visible = false;

            labelOutputFilm.Visible = false;
            labelFilms.Visible = true;
            
            buttonReservation.Visible = true;
            ButtonAddPlace.Visible = false;
            buttonSearch.Visible = false;
            buttonDeleteReservation.Visible = false;
            ButtonDelPlace.Visible = false;

            ClearTextBox();
            textBoxFilms.Clear();
        }

        private void УзнатьБроньНаФильмToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxFilms.Visible = false;
            textBoxHall.Visible = false;
            textBoxPlace.Visible = false;
            textBoxRow.Visible = false;

            comboBoxHallRes.Location = new Point(46, 64);
            comboBoxRowRes.Location = new Point(46, 64);
            comboBoxPlaceRes.Location = new Point(49, 64);
            comboBoxHallRes.Visible = true;
            comboBoxRowRes.Visible = true;
            comboBoxPlaceRes.Visible = true;
            comboBoxHallPD.Visible = false;
            comboBoxRowPD.Visible = false;
            comboBoxPlacePD.Visible = false;

            labelOutputFilm.Location = new Point(15, 64);
            labelFilms.Visible = true;
            
            buttonReservation.Visible = false;
            buttonSearch.Location = new Point(16, 123);
            buttonSearch.Visible = true;
            buttonDeleteReservation.Visible = false;
            ButtonAddPlace.Visible = false;
            ButtonDelPlace.Visible = false;


        }

        private void удалитьБроньToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            labelFilms.Visible = false;
            labelOutputFilm.Visible = false;
           
            textBoxHall.Visible = false;
            textBoxPlace.Visible = false;
            textBoxRow.Visible = false;
            textBoxFilms.Visible = false;

            comboBoxHallRes.Location = new Point(46, 64);
            comboBoxRowRes.Location = new Point(46, 64);
            comboBoxPlaceRes.Location = new Point(49, 64);
            comboBoxHallRes.Visible = true;
            comboBoxRowRes.Visible = true;
            comboBoxPlaceRes.Visible = true;
            comboBoxHallPD.Visible = false;
            comboBoxRowPD.Visible = false;
            comboBoxPlacePD.Visible = false;

            buttonDeleteReservation.Location = new Point(15, 52);
            buttonDeleteReservation.Visible = true;
            buttonReservation.Visible = false;
            buttonSearch.Visible = false;
            ButtonAddPlace.Visible = false;
            ButtonDelPlace.Visible = false;
        }

        public LinkedList.List node = new LinkedList.List();
        public LinkedList.Node table = new LinkedList.Node();
        public LinkedList.Tree root = new LinkedList.Tree();
        public string films = "";
        private void buttonReservation_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxFilms.Text.Equals("") || textBoxHall.Text.Equals("") || textBoxPlace.Text.Equals("") || textBoxRow.Text.Equals(""))
                {
                    MessageBox.Show("Вы заполнили не все поля!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    uint value = uint.Parse(textBoxHall.Text);
                    value += uint.Parse(textBoxRow.Text);
                    value += uint.Parse(textBoxPlace.Text);

                    if (root == null)
                        root = new LinkedList.Tree();

                    string str = root.Find(root, new LinkedList.Films("", KeyTexBox()));
                    if (str != "")
                    {
                        MessageBox.Show("Выбранное место уже имеет бронь!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        bool check = node.CheckPlace(KeyTexBox(), MiddleSquare(value));
                        if (check == true)
                        {
                            MessageBox.Show("Выбранное место не существует! Место можно добавить в разделе \"Редактор мест\"", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        }
                        else
                        {
                            root = root.Insert(root, new LinkedList.Films(textBoxFilms.Text, KeyTexBox()));
                            films += textBoxFilms.Text + "_" + textBoxHall.Text + "-" + textBoxRow.Text + "-" + textBoxPlace.Text + ",";

                            comboBoxHallRes.Items.Add(textBoxHall.Text);
                            comboBoxRowRes.Items.Add(textBoxRow.Text);
                            comboBoxPlaceRes.Items.Add(textBoxPlace.Text);
                            checksave = false;
                        }
                    }
                    ClearTextBox();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Данные не могу быть обработаны! Превышено допустимое значение.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                ClearTextBox();
            }
        }

        
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (comboBoxHallRes.Text.Equals("") || comboBoxPlaceRes.Text.Equals("") || comboBoxRowRes.Text.Equals(""))
            {
                MessageBox.Show("Вы заполнили не все поля!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else
            {
                string str = comboBoxHallRes.Text;
                str += comboBoxRowRes.Text;
                str += comboBoxPlaceRes.Text;
                uint KeySF = uint.Parse(str);

                labelOutputFilm.Text = root.Find(root, new LinkedList.Films("", KeySF));
                if (labelOutputFilm.Text == "")
                {
                    MessageBox.Show("Выбранное место еще не забронированно на фильм!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    labelOutputFilm.Visible = false;
                }
                else
                    labelOutputFilm.Visible = true;
            }
        }

        private void buttonDeleteReservation_Click(object sender, EventArgs e)
        {
            if (comboBoxHallRes.Text.Equals("") || comboBoxPlaceRes.Text.Equals("") || comboBoxRowRes.Text.Equals(""))
            {
                MessageBox.Show("Вы заполнили не все поля!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else
            {
                string str = comboBoxHallRes.Text;
                str += comboBoxRowRes.Text;
                str += comboBoxPlaceRes.Text;
                uint KeySF = uint.Parse(str);

                str = root.Find(root, new LinkedList.Films("", KeySF));
                if (str == "")
                {
                    MessageBox.Show("Выбранное место не имеет брони!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    root = root.Remove(root, new LinkedList.Films(str, KeySF));
                    films = films.Replace(str + "_" + comboBoxHallRes.Text + "-" + comboBoxRowRes.Text + "-" + comboBoxPlaceRes.Text + ",", "");

                    comboBoxHallRes.Items.Remove(comboBoxHallRes.Text);
                    comboBoxRowRes.Items.Remove(comboBoxRowRes.Text);
                    comboBoxPlaceRes.Items.Remove(comboBoxPlaceRes.Text);
                    checksave = false;
                }
            }
        }

        private void textBoxHall_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }

        private void textBoxRow_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }

        private void textBoxPlace_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }

        private void textBoxFilms_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (Char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == '\b')
            {
                e.Handled = false;
            }
        }
        
        private void добавитьМестоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelFilms.Visible = false;
            labelOutputFilm.Visible = false;

            textBoxFilms.Visible = false;
            textBoxHall.Visible = true;
            textBoxPlace.Visible = true;
            textBoxRow.Visible = true;

            ButtonAddPlace.Location = new Point(11, 52);
            ButtonAddPlace.Visible = true;
            buttonReservation.Visible = false;
            buttonDeleteReservation.Visible = false;
            buttonSearch.Visible = false;
            ButtonDelPlace.Visible = false;

            comboBoxHallPD.Visible = false;
            comboBoxPlacePD.Visible = false;
            comboBoxRowPD.Visible = false;
            comboBoxHallRes.Visible = false;
            comboBoxRowRes.Visible = false;
            comboBoxPlaceRes.Visible = false;

            ClearTextBox();
        }
        private void удалитьМестоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelFilms.Visible = false;
            labelOutputFilm.Visible = false;

            comboBoxHallPD.Location = new Point(46, 64);
            comboBoxRowPD.Location = new Point(46, 64);
            comboBoxPlacePD.Location = new Point(49, 64);
            comboBoxHallPD.Visible = true;
            comboBoxPlacePD.Visible = true;
            comboBoxRowPD.Visible = true;
            comboBoxHallRes.Visible = false;
            comboBoxRowRes.Visible = false;
            comboBoxPlaceRes.Visible = false;

            ButtonDelPlace.Visible = true;
            ButtonAddPlace.Visible = false;
            buttonSearch.Visible = false;
            buttonReservation.Visible = false;
            buttonDeleteReservation.Visible = false;
            ButtonDelPlace.Location = new Point(11, 52);

            textBoxHall.Visible = false;
            textBoxPlace.Visible = false;
            textBoxRow.Visible = false;
            textBoxFilms.Visible = false;
        }

        public string place = "";
        private void ButtonDelPlace_Click(object sender, EventArgs e)
        {
            if (comboBoxHallPD.Text.Equals("") || comboBoxPlacePD.Text.Equals("") || comboBoxRowPD.Text.Equals(""))
            {
                MessageBox.Show("Вы заполнили не все поля!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else
            {
                uint value = uint.Parse(comboBoxHallPD.Text);
                value += uint.Parse(comboBoxRowPD.Text);
                value += uint.Parse(comboBoxPlacePD.Text);

                string str = comboBoxHallPD.Text;
                str += comboBoxRowPD.Text;
                str += comboBoxPlacePD.Text;
                uint KeyPD = uint.Parse(str);

                if (root == null) 
                    root = new LinkedList.Tree();

                str = root.Find(root, new LinkedList.Films("", KeyPD));
                if (str != "")
                {
                    MessageBox.Show("Невозможно удалить забронированное место!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    bool check = node.CheckPlace(KeyPD, MiddleSquare(value));
                    if (check == true)
                    {
                        MessageBox.Show("Удаляемого места не существует!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        node.DeletePlace(KeyPD, MiddleSquare(value));
                        place = place.Replace(comboBoxHallPD.Text + "-" + comboBoxRowPD.Text + "-" + comboBoxPlacePD.Text + " ", "");

                        comboBoxHallPD.Items.Remove(comboBoxHallPD.Text);
                        comboBoxPlacePD.Items.Remove(comboBoxPlacePD.Text);
                        comboBoxRowPD.Items.Remove(comboBoxRowPD.Text);
                        checksave = false;
                    }
                }
            }
        }

        private void ButtonAddPlace_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxHall.Text.Equals("") || textBoxPlace.Text.Equals("") || textBoxRow.Text.Equals(""))
                {
                    MessageBox.Show("Вы заполнили не все поля!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    uint value = uint.Parse(textBoxHall.Text);
                    value += uint.Parse(textBoxRow.Text);
                    value += uint.Parse(textBoxPlace.Text);

                    if (textBoxHall.Text.Substring(0, 1) == "0" || textBoxRow.Text.Substring(0, 1) == "0" || textBoxPlace.Text.Substring(0, 1) == "0")
                    {
                        checksave = true;
                        value = uint.Parse("");
                    }

                    bool check = node.CheckPlace(KeyTexBox(), MiddleSquare(value));
                    if (check == false)
                    {
                        MessageBox.Show("Добавляемое место уже существует!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        node.AddPlace(KeyTexBox(), MiddleSquare(value));
                        place += textBoxHall.Text + "-" + textBoxRow.Text + "-" + textBoxPlace.Text + " ";

                        comboBoxHallPD.Items.Add(textBoxHall.Text);
                        comboBoxPlacePD.Items.Add(textBoxPlace.Text);
                        comboBoxRowPD.Items.Add(textBoxRow.Text);
                        checksave = false;
                    }
                    ClearTextBox();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Данные не могу быть обработаны! Введено некорректное значение или превышено допустимое", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                ClearTextBox();
            }
        }

        /// <summary>
        /// Хеш-функция, которая суммирует числа ключа, возводит в квадрат и возвращает середину этого квадрата
        /// </summary>
        /// <returns></returns>
        public uint MiddleSquare(uint value)
        {
            uint index = (uint)Math.Pow(value, 2);

            string str = index.ToString();
            uint[] array = new uint[str.Length];

            if (table.mass.Length % 10 == 0)
            {
                int LengthMass = table.mass.Length - 1;
                str = LengthMass.ToString();
            }
            else str = table.mass.Length.ToString();

            uint count = 0;
            while (index != 0)
            {
                array[count] = index % 10;
                index = index / 10;
                count++;
            }
            Array.Reverse(array);

            string outstr = "";
            string checkstr;
            if (str.Length > 2)
            {
                switch (array.Length / str.Length)
                {
                    case 0:
                        switch (array.Length / 2)
                        {
                            case 0:
                                return array[array.Length / 2];
                            case 1:
                                return array[array.Length / 2];
                            default:
                                for (int i = 1; i < array.Length - 1; i++)
                                {
                                    if (outstr == "")
                                    {
                                        checkstr = array[i].ToString();
                                        outstr = checkstr == "0" ? "" : checkstr;
                                    }
                                    else outstr += array[i];
                                }
                                index = uint.Parse(outstr);
                                return index;
                        }
                    default:
                        if ((array.Length == str.Length) || (array.Length - str.Length == 1))
                        {
                            for (int i = 1; i < array.Length - 1; i++)
                            {
                                if (outstr == "")
                                {
                                    checkstr = array[i].ToString();
                                    outstr = checkstr == "0" ? "" : checkstr;
                                }
                                else outstr += array[i];
                            }
                            index = uint.Parse(outstr);
                            return index;
                        }

                        for (int i = 0; i < str.Length; i++)
                        {
                            if (outstr == "")
                            {
                                checkstr = array[i].ToString();
                                outstr = checkstr == "0" ? "" : checkstr;
                            }
                            else outstr += array[array.Length / str.Length + i];
                        }
                        index = uint.Parse(outstr);
                        return index;
                }
            }
            else 
            {
                switch (array.Length / 2)
                {
                    case 0:
                        return array[array.Length / 2];
                    case 1:
                        return array[array.Length / 2];
                    default:
                        if (str.Length == 2)
                        {
                            outstr += array[array.Length / 2 - 1];
                            outstr = outstr == "0" ? "" : outstr;
                            outstr += array[(array.Length / 2)];
                            index = uint.Parse(outstr);
                            return index;
                        }
                        else
                        {
                            outstr += array[(array.Length / 2)];
                            index = uint.Parse(outstr);
                            return index;
                        }
                }
            }
        }

        /// <summary>
        /// Формирует ключ из вводимых пользователем данных
        /// </summary>
        /// <returns></returns>
        public uint KeyTexBox()
        {
            string str = textBoxHall.Text;
            str += textBoxRow.Text;
            str += textBoxPlace.Text;
            uint key = uint.Parse(str);
            return key;
        }

        /// <summary>
        /// Очищаете все поля элемента textbox
        /// </summary>
        public void ClearTextBox()
        {
            textBoxHall.Clear();
            textBoxPlace.Clear();
            textBoxRow.Clear();
        }

        public bool checksave = false;
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checksave == false)
            {
                var result = MessageBox.Show("Несохраненные данные будут утеряны! Сохранить изменения?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                if (result == DialogResult.No)
                {
                    int index;
                    string word;
                    if (placereserv != "")
                    {
                        PlaceWrite = new StreamWriter(Saves + Folder + FilePlace);

                        while (placereserv != "")
                        {
                            index = placereserv.IndexOf(" ");
                            word = placereserv.Substring(0, index);
                            PlaceWrite.WriteLine(word);
                            word += " ";
                            placereserv = placereserv.Replace(word, "");
                        }
                        PlaceWrite.Close();
                    }

                    if (filmsreserv != "")
                    {
                        FilmsWrite = new StreamWriter(Saves + Folder + FileFilms);

                        while (filmsreserv != "")
                        {
                            index = filmsreserv.IndexOf(",");
                            word = filmsreserv.Substring(0, index);
                            FilmsWrite.WriteLine(word);
                            word += ",";
                            filmsreserv = filmsreserv.Replace(word, "");
                        }
                        FilmsWrite.Close();
                    }
                }
                else if (result == DialogResult.Yes)
                    сохранитьToolStripMenuItem_Click(null, null);
            }
        }

        public void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index;
            string word;
            string copy = "";
            if (place != "")
            {
                PlaceWrite = new StreamWriter(Saves + Folder + FilePlace);

                while (place != "")
                {
                    index = place.IndexOf(" ");
                    word = place.Substring(0, index);
                    PlaceWrite.WriteLine(word);
                    word += " ";
                    copy += word;
                    place = place.Replace(word, "");
                }
                place = copy;
                copy = "";
                PlaceWrite.Close();
                checksave = true;
                placereserv = "";
            }
            else
            {
                PlaceWrite = new StreamWriter(Saves + Folder + FilePlace);
                PlaceWrite.Close();
            }

            if (films != "")
            {
                FilmsWrite = new StreamWriter(Saves + Folder + FileFilms);

                while (films != "")
                {
                    index = films.IndexOf(",");
                    word = films.Substring(0, index);
                    FilmsWrite.WriteLine(word);
                    word += ",";
                    copy += word;
                    films = films.Replace(word, "");
                }
                films = copy;
                FilmsWrite.Close();
                checksave = true;
                filmsreserv = "";
            }
            else
            {
                FilmsWrite = new StreamWriter(Saves + Folder + FileFilms);
                FilmsWrite.Close();
            }
        }
    }
}
