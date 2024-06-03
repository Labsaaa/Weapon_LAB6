using MilitaryUnit;

namespace Weapon8V23
{

    public partial class MainWin : Form
    {
        // Global Variables
        private MilitaryUnit.MilitaryUnit unit;


        // Initialization function
        private void Awake()
        {
            unit = new MilitaryUnit.MilitaryUnit();
            Update();
        }

        // Main window update
        private void Update()
        {
            weaponList.Items.Clear();

            foreach (var weapon in unit.weapons)
            {
                string text = $"{weapon.Name.Truncate(15)} | {weapon.Weight.ToString().Truncate(15)} | {weapon.CalculateCost().ToString().Truncate(12,true)}$";
                weaponList.Items.Add(text);
            }

            if (weaponList.Items.Count == 15)
                addBtn.Enabled = false;
            else
                addBtn.Enabled = true;

            if (weaponList.SelectedIndex < 0)
            {
                editBtn.Enabled = false;
                removeBtn.Enabled = false;
            }
            else
            {
                editBtn.Enabled = true;
                removeBtn.Enabled = true;
            }

            costLabel.Text = unit.CalculateTotalCost().ToString() + "$";

        }

        // Handling button click events

        private void onAddWeapon(object sender, EventArgs e)
        {
            ChooseWin chooseWeapon = new ChooseWin();
            chooseWeapon.ShowDialog();

            string result = chooseWeapon.result;

            if (result == "Gun")
            {
                GunWin gunWin = new GunWin();
                gunWin.ShowDialog();

                if (gunWin.create == false)
                    return;

                Gun gun = new Gun(gunWin.name, gunWin.weight, gunWin.capacity, gunWin.calibre);
                unit.weapons.Add(gun);
            }
            else if (result == "Machinegun")
            {
                MachinegunWin mwin = new MachinegunWin();
                mwin.ShowDialog();

                if (mwin.create == false) 
                    return;

                Machinegun gun = new Machinegun(mwin.name, mwin.weight, mwin.capacity, mwin.calibre, mwin.rapidity);
                unit.weapons.Add(gun);
            }
            else if (result == "Blade")
            {
                BladeWin bladeWin = new BladeWin();
                bladeWin.ShowDialog();

                if (bladeWin.create == false) 
                    return;

                Blade wp = new Blade(bladeWin.name, bladeWin.weight, bladeWin.length, bladeWin.handCount);
                unit.weapons.Add(wp);
            }
            else
                return;

            Update();
        }

        private void onEditWeapon(object sender, EventArgs e)
        {
            int index = weaponList.SelectedIndex;

            if (index < 0)
                return;

            if (unit.weapons[index] is Gun)
            {
                Gun gun = unit.weapons[index] as Gun;

                GunWin gunWin = new GunWin(gun.Name, gun.Weight, gun.Capacity, gun.Calibre);
                gunWin.ShowDialog();

                if (gunWin.create == false)
                    return;

                unit.weapons[index] = new Gun(gunWin.name, gunWin.weight, gunWin.capacity, gunWin.calibre);
            }
            else if (unit.weapons[index] is Blade)
            {
                Blade bld = unit.weapons[index] as Blade;

                BladeWin bldWin = new BladeWin(bld.Name, bld.Weight, bld.Length, bld.HandCount);
                bldWin.ShowDialog();

                if (bldWin.create == false)
                    return;

                unit.weapons[index] = new Blade(bldWin.name, bldWin.weight, bldWin.length, bldWin.handCount);
            }
            else if (unit.weapons[index] is Machinegun)
            {
                Machinegun mg = unit.weapons[index] as Machinegun;

                MachinegunWin mgWin = new MachinegunWin(mg.Name, mg.Weight, mg.Capacity, mg.Calibre, mg.Rapidity);
                mgWin.ShowDialog();

                if (mgWin.create == false)
                    return;

                unit.weapons[index] = new Machinegun(mgWin.name, mgWin.weight, mgWin.capacity, mgWin.calibre, mgWin.rapidity);
            }
            else return;

            Update();
        }

        private void onRemoveWeapon(object sender, EventArgs e)
        {
            int index = weaponList.SelectedIndex;

            if (index < 0) 
                return;

            unit.weapons.RemoveAt(index);

            Update();
        }

        private void onWeaponListClick(object sender, EventArgs e)
        {
            if (weaponList.Items.Count == 15)
                addBtn.Enabled = false;
            else
                addBtn.Enabled = true;

            if (weaponList.SelectedIndex < 0)
            {
                editBtn.Enabled = false;
                removeBtn.Enabled = false;
            }
            else
            {
                editBtn.Enabled = true;
                removeBtn.Enabled = true;
            }
        }

        // - - - - - - - - - - - - - - - - - - - -

        public MainWin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Awake();
        }
    }
}

