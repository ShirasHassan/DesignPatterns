namespace DesignPatterns.Behavioural.Iterator
{
    public class WordsIterator : Iterator
    {
        private WordsCollection _wordsCollection;
        private bool _isReversed;
        private int _position = -1;
        
        public WordsIterator(WordsCollection wordsCollection, bool isReversed)
        {
            _wordsCollection = wordsCollection;
            _isReversed = isReversed;
            if (isReversed)
            {
                this._position = wordsCollection.getItems().Count;
            }
        }
        
        public override object Current()
        {
            return this._wordsCollection.getItems()[_position];
        }

        public override int Key()
        {
            return this._position;
        }
        
        public override bool MoveNext()
        {
            int updatedPosition = this._position + (this._isReversed ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < this._wordsCollection.getItems().Count)
            {
                this._position = updatedPosition;
                return true;
            }
            else
            {
                return false;
            }
        }


        public override void Reset()
        {
            this._position = this._isReversed ? this._wordsCollection.getItems().Count - 1 : 0;
        }

    }
}