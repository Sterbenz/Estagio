function createController(game) {

    var $entry = $('.entrada');
    var $gaps = $('.lacunas');

    function showGaps() {
        $gaps.empty();
        game.getGaps().forEach(function (gap) {
            $('<li>')
                .addClass('lacuna')
                .text(gap)
                .appendTo($gaps);
        });
    };

    function changePlaceHolder(text) {

        $entry.attr('placeholder', text);
    };

    function storeSecretWord() {

        try {
            game.setSecretWord($entry.val().trim());
            $entry.val('');
            changePlaceHolder('chuta');
            showGaps();
        } catch(err) {
            alert(err.message);
        }

    };

    function restart() {

        game.restart();
        $gaps.empty();
        changePlaceHolder('palavra secreta');
    };

    function leChute() {

        try {
            game.attempt($entry.val().trim().substr(0, 1));
            $entry.val('');
            showGaps();

            if(game.winOrLose()) {

                setTimeout(function() {
                    if(game.win()) {
                        alert('Parabéns, você ganhou');
                    } else if (game.lose()) {
                        alert('Que pena, tente novamente')
                    }
                    restart();                    
                }, 200);
            }
        } catch(err) {
            alert(err.message);
        }
    };

    function start() {

        $entry.keypress(function (event) {
            if (event.which == 13) {
                switch (game.getStage()) {
                    case 1:
                        storeSecretWord();
                        break;
                    case 2:
                        leChute();
                        break;
                }
            }
        });
    };

    return { start: start };
};