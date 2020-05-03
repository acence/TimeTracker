/// <binding BeforeBuild='build:css-sass-public' ProjectOpened='watch' />
var gulp = require('gulp');
var sass = require('gulp-sass');
var rename = require('gulp-rename');

gulp.task('build:css-sass-public', () => {
    return gulp.src(['./Styles/*.scss'])
        .pipe(sass().on('error', sass.logError))
        .pipe(rename((path) => {
            path.basename = path.basename.toLowerCase();
        }))
        .pipe(gulp.dest('./wwwroot/css'));
});

gulp.task('watch', function () {
    gulp.watch(['./Content/**/*.scss'], gulp.series('build:css-sass-public'));
}); 