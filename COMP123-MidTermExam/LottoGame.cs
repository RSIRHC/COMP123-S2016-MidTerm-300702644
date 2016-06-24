using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Name: Christopher Ritchil 
 * Student id: 300702644
 * Date Created: June 24, 2016
 * Date Modified: June 24, 2016
 * Version 0.1.0
 * Description: This application demonstrate console application for lottery number picker
 */

namespace COMP123_MidTermExam
{
    /**
     * <summary>
     * This abstract class is a blueprint for all Lotto Games
     * </summary>
     * 
     * @class LottoGame
     * @property {int} ElementNum;
     * @property {int} SetSize;
     */
    public abstract class LottoGame
    {
        // PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // CREATE private fields here --------------------------------------------
        private List<int> _elementList;
        private int _elementNumber;
        private List<int> _numberList;
        private Random _random;
        private int _setSize;


        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // CREATE public properties here -----------------------------------------
        public List<int> ElementList
        {
            set
            {
                this._elementList = value;
            }
        }

        public int ElementNumber
        {
            get
            {
                return this._elementNumber;
            }

            set
            {
                this._elementNumber = value;
            }
        }

        public List<int> NumberList
        {
            get
            {
                return this._numberList;
            }

            set
            {
                this._numberList = value;
            }
        }

        public Random random
        {
            set
            {
                this._random = value;
            }
        }

        public int SetSize
        {
            get
            {
                return this._setSize;
            }

            set
            {
                this._setSize = value;
            }
        }

        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This constructor takes two parameters: elementNumber and setSize
         * The elementNumber parameter has a default value of 6
         * The setSize parameter has a default value of 49
         * </summary>
         * 
         * @constructor LottoGame
         * @param {int} elementNumber
         * @param {int} setSize
         */
        public LottoGame(int elementNumber = 6, int setSize = 49)
        {
            // assign elementNumber local variable to the ElementNumber property
            this.ElementNumber = elementNumber;

            // assign setSize local variable tot he SetSize property
            this.SetSize = setSize;

            // call the _initialize method
            this._initialize();

            // call the _build method
            this._build();
        }


        // OVERRIDEN METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
         * <summary>
         * Override the default ToString function so that it displays the current
         * ElementList
         * </summary>
         * 
         * @override
         * @method ToString
         * @returns {string}
         */
        public override string ToString()
        {
            // create a string variable named lottoNumberString and intialize it with the empty string
            string lottoNumberString = String.Empty;

            // for each lottoNumber in ElementList, loop...
            foreach (int lottoNumber in ElementList)
            {
                // add lottoNumber and appropriate spaces to the lottoNumberString variable
                lottoNumberString += lottoNumber > 9 ? (lottoNumber + " ") : (lottoNumber + "  ");
            }

            return lottoNumberString;
        }

        // PRIVATE METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // CREATE the private _build method here -----------------------------------
        private void _build()
        {
            for (int i = 1; i < SetSize + 1; i++)
            {
                NumberList.Add(i);
            }
        }

        // CREATE the private _initialize method here -----------------------------
        private void _initialize()
        {

            _numberList = new List<int>();
            _elementList = new List<int>();
            _random = new Random();
        }
    }


    // PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    // CREATE the public PickElements method here ----------------------------
    public void PickElements()
    {

    }

}
}
