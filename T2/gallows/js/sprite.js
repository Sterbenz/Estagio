function createSprite(selector) {

    function hasNext() {

        return current + 1 <= last;
    }

    function reset() {

        moveFrame(frames[current], frames[0])
        current = 0;
    };

    // nova função!

    function isFinished() {

        return !hasNext();
    };

    function moveFrame (from, to) {

        $el.removeClass(from)
            .addClass(to);
    }

    function nextFrame() {

        if (hasNext()) moveFrame (frames[current], frames[++current]);
    }

    var $el = $(selector);

    var frames = [
        'frame1', 'frame2', 'frame3', 'frame4', 'frame5',
        'frame6', 'frame7', 'frame8', 'frame9'
    ];

    var current = 0;

    var last = frames.length - 1;

    $el.addClass(frames[current]);

    return { nextFrame: nextFrame, isFinished: isFinished, reset: reset };
}