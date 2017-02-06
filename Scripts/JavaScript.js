$(document).ready(function () {

    var interval;
    //tao auto chuyen slide
    function startSlide() {
        interval = setInterval(function () {
            $('#next').click();
        }, 1500);

    }

    //xoa interval
    function stopSlide() {
        clearInterval(interval);
    }


    // click prev
    $('#prev').on('click', function () {
        //stopSlide de khi click prev no se khong auto chuyen den hinh ke tiep
        stopSlide();
        var stt = $('img.active').attr('stt'); //0
        //remove class active of img & li
        $('img').eq(stt).removeClass('active');
        $('li').eq(stt).removeClass('active');

        prev = --stt;  //-1
        if (prev == -1)
            prev = 4;

        //add class active of img & li
        $('img').eq(prev).addClass('active');
        $('li').eq(prev).addClass('active');
        startSlide();
    });

    //click next

    $('#next').on('click', function () {

        //stopSlide de khi click next no se khong auto chuyen den hinh ke tiep
        stopSlide();
        //get stt of img show 
        var stt = $('img.active').attr('stt'); //4

        //remove class active of img & li
        $('img').eq(stt).removeClass('active');
        $('li').eq(stt).removeClass('active');

        next = ++stt; // 5
        if (next == 5)
            next = 0;

        //add class active of img & li index next
        $('img').eq(next).addClass('active');
        $('li').eq(next).addClass('active');
        startSlide();
    });


    // mouseover -> stopSlide & mouseout -> startSlide
    $('img').on('mouseover', stopSlide).on('mouseout', startSlide);
    startSlide();



    $('li').on('click', function () {
        stopSlide();
        var stt = $('img.active').attr('stt'); //4
        var index = $(this).attr('index');
        $('img').eq(stt).removeClass('active');
        $('li').eq(stt).removeClass('active');

        //add class active of img & li index next
        $('img').eq(index).addClass('active');
        $('li').eq(index).addClass('active');
        startSlide();
    });


});