var createGame = function () {

    var stage = 1;
    var gaps = [];
    var secretWord = '';    

    function createGap() {
        for (let i = 0; i < secretWord.length; i++) {
            gaps.push('');
        }
    };

    function nextStage() {

        stage = 2;
    };

    function setSecretWord(word) {
        if(!word.trim()) throw Error('Palavra inválida');
        secretWord = word;
        createGap();
        nextStage();
    };

    function getGaps() {

        return gaps;
    };

    function getStage() {

        return stage;
    };

    function attempt(kick){
        if(!kick.trim()) throw Error('Chute inválido');
        var exp = RegExp(kick,"gi"),
            result,
            right = false;

        while (result = exp.exec(secretWord)) 
        right = gaps[result.index] = kick;

        if (!right) sprite.nextFrame();
    }

    function win() {

        return gaps.length 
            ? !gaps.some(function(gap) {
                return gap == '';
            })
            : false;
    };

    var lose = function () {

        return sprite.isFinished();
    };

    var winOrLose = function () {

        return win() || lose();
    };

    var restart = function () {

        stage = 1;
        secretWord = '';
        gaps = [];
        sprite.reset();
    };

    return {
        setSecretWord: setSecretWord, 
        getGaps: getGaps,
        getStage: getStage,
        attempt: attempt,
        win: win,
        lose: lose,
        winOrLose: winOrLose,
        restart: restart
    }
};